using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;

namespace FitnessSportGym
{
    public partial class AgregarEntrenador : Form
    {
         EntrenadorBD entre = new EntrenadorBD();
        public AgregarEntrenador()
        {
            InitializeComponent();
             //Apareceran automatico los entrenadores ya registrados en un datagridview
            DataTable dtDatos = new DataTable();

            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("Select Entre_ID,Nombre From entrenador;", ConectarBD.ObtenerConexion());

            mdaDatos.Fill(dtDatos);

            entrenador.DataSource = dtDatos;
        }
        private FilterInfoCollection dispositivo; //Detectar la camara que se usa
        private VideoCaptureDevice fuente; //Objeto de Video


        //Variables de los campos a llenar en la base de datos
        private SaveFileDialog guardar;
        private Bitmap foto2;
        private Bitmap foto; //Objeto para el formato y variable de Imagen tomada
        private void GuardarB_Click(object sender, EventArgs e)
        {
             //Se verifica si algun campo esta vacio 
             if (NomT.Text == "" || ApesT.Text == "" || TelT.Text == "" || IdET.Text == "" || TipoT.Text == "" || Contra.Text == "")
             {

                  MessageBox.Show("Bede insertar datos");

             }
             //Verificacion de la contrasenias si las contrasenias no son iguales no se guardara
             if (Contra.Text != contraseña2.Text ){
                  MessageBox.Show("Vuelva a escribir la contraseña");
                  contraseña2.Text = "";
                  Contra.Text = "";


             }
             else
             {
                  //entra al metodo de verificacion si el entrenador por medio de la id ya existe
                  if (entre.verificacioninstructor(Convert.ToInt32(IdET.Text)) == 0)
                  {
                       //hace lo mismo que el la ventana registro de clientes que guarda la url
                       string url;
                       guardar = new SaveFileDialog(); //Crear el objeto que nos permitira abrir el dialogo para guardar la imagen           
                       guardar.Filter = "Imagenes JPG | .jpg"; //Elegir el formato en el cual se guarda la imagen

                       guardar.FileName = "C:\\\\\\Users\\\\\\Public\\\\\\FOTOS\\\\\\ENTRENADOR\\\\\\" + IdET.Text + ".jpg";
                       foto.Save(guardar.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                       url = guardar.FileName;

                       //al mismo tiempo se les envia los parametros para agregar los entrenadores y usuario
                       MessageBox.Show(entre.instentre(Convert.ToInt32(IdET.Text), NomT.Text, ApesT.Text, TelT.Text, Convert.ToInt32(TipoT.Text), url));
                       MessageBox.Show(entre.instusuarios(Convert.ToInt32(IdET.Text), Convert.ToInt32(TipoT.Text), NomT.Text, Contra.Text));
                       NomT.Text = null;
                       ApesT.Text = null;
                       TelT.Text = null;
                       IdET.Text = null;
                       TipoT.Text = null;
                       Contra.Text = null;
                       contraseña2.Text = null;
                       pictureBox3.Image = null;

                  }
                  else
                  {
                       MessageBox.Show("Imposible de registrar, el registro ya existe");
                  }
             }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEntrenador_Load(object sender, EventArgs e)
        {
             dispositivo = new FilterInfoCollection(FilterCategory.VideoInputDevice); // Crear el objeto que identifica nuestros dispositivos capaces de capturar video.
             //Iniciar la captura y toma de video en este campo. Del cual se tomara la foto.

             foreach (FilterInfo x in dispositivo)
             { // Seleccionar los diferentes dispositivos que tenemos para capturar video
                  CamBox.Items.Add(x.Name); //Mostrar el nombre del dispositivo para capturar videos.
                  ;
             }
             CamBox.SelectedIndex = 0;
        }

        private void CapturarC_Click(object sender, EventArgs e)
        {
             //Capturar el Frame actual del video al ser presionado y mostrarlo en el picturebox
             pictureBox3.Image = videoSourcePlayer1.GetCurrentVideoFrame(); //Presentar la imagen capturada en el picturebox
             foto2 = videoSourcePlayer1.GetCurrentVideoFrame();
             foto = foto2;
        }

        private void CamBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             //Seleccionar los/el dispositivo(s) de video disponibles para hacer la captura de foto
             fuente = new VideoCaptureDevice(dispositivo[CamBox.SelectedIndex].MonikerString);
        }

        private void EliminarC_Click(object sender, EventArgs e)
        {
             //Se limpian los campos
             pictureBox3.Image = null;
             NomT.Text = null;
             ApesT.Text = null;
             TelT.Text = null;
             IdET.Text = null;
             TipoT.Text = null;
             if (foto != null)
             {
                  foto = null;
                  foto2 = null;

             }
        }

        private void IniciarC_Click(object sender, EventArgs e)
        {
             //Iniciar la captura de video dependiendo del dispositivo seleccionado en el ComboBox
             videoSourcePlayer1.VideoSource = fuente;
             videoSourcePlayer1.Start();
        }

        private void AgregarEntrenador_FormClosing(object sender, FormClosingEventArgs e)
        {
             //Al cerrar  el form, vaciar todos los campos.
             try
             {
                  pictureBox3.Image = null;
                  NomT.Text = null;
                  ApesT.Text = null;
                  TelT.Text = null;
                  IdET.Text = null;
                  TipoT.Text = null;

             }
             catch
             {


             }
        }

        private void AgregarEntrenador_FormClosed(object sender, FormClosedEventArgs e)
        {
             //Se detiene la camara
             try
             {
                  videoSourcePlayer1.SignalToStop();
                  pictureBox1.Image = null;

             }
             catch { }
        }

        private void TipoT_KeyPress(object sender, KeyPressEventArgs e)
        {
             //Verificacion del tipo que solo son enteros
             if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
             {
                  MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  e.Handled = true;
                  return;
             }
        }

        private void IdET_KeyPress(object sender, KeyPressEventArgs e)
        {
             //verificacion de qu ela id sea solo entero
             if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
             {
                  MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  e.Handled = true;
                  return;
             }
        }
         //verificacion del telefono solo se permina enteros
        private void TelT_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
             {
                  MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  e.Handled = true;
                  return;
             }
        }
    }
}
