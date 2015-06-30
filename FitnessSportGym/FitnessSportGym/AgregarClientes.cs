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

    public partial class AgregarClientes : Form
    {
         ClientesBD client = new ClientesBD();
        public AgregarClientes()
        {
            InitializeComponent();
            DataTable dtDatos = new DataTable();

            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("Select Entre_ID,Nombre From entrenador;", ConectarBD.ObtenerConexion());

            mdaDatos.Fill(dtDatos);

            entrenador.DataSource = dtDatos;

        }

        //Declaracion de Variables a utilizar de forma global.
        private FilterInfoCollection dispositivo; //Detectar la camara que se usa
        private VideoCaptureDevice fuente; //Objeto de Video


        //Variables de los campos a llenar en la base de datos
        private SaveFileDialog guardar;
        private Bitmap foto2;
        private Bitmap foto; //Objeto para el formato y variable de Imagen tomada


        private void AgregarClientes_Load(object sender, EventArgs e)
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

        private void GuardarB_Click(object sender, EventArgs e)
        {
             //Boton de Guardar

             //Recordar todos los espacios excedentes en los campos.
             Cliente Datos_Cliente = new Cliente();
             //Datos_Cliente.Nombre = NomT.Text.Trim();
             //Datos_Cliente.Apellido_Paterno = ApepT.Text.Trim();
             //Datos_Cliente.Apellido_Materno = ApemT.Text.Trim();
             //Datos_Cliente.Telefono = TelT.Text.Trim();
             //Datos_Cliente.Correo = CorreoT.Text.Trim();
             //Datos_Cliente.Fecha = fecha.Value.Year + "/" + fecha.Value.Month + "/" + fecha.Value.Day;
             //Datos_Cliente.Cliente_ID = Convert.ToInt32(IdCT.Text);
             //Datos_Cliente.Entrenador_ID = Convert.ToInt32(IdET.Text);


             guardar = new SaveFileDialog(); //Crear el objeto que nos permitira abrir el dialogo para guardar la imagen           
             guardar.Filter = "Imagenes JPG | .jpg"; //Elegir el formato en el cual se guarda la imagen



             //Asegurar la ruta valida           
             if (guardar.FileName != null)
             { //Si el nombre no existe, crear la imagen con el nombre asignado.
                  if (foto == null) //Si la plantilla de la foto esta vacia sucede:
                  {
                       MessageBox.Show("Tome una foto primero");
                       //try
                       //{//Que quiero intentar hacer?

                       //     MessageBox.Show("Tome una foto primero");
                       //}
                       //catch
                       //{//Permite que el programa no se cierre hasta corregir los errores

                       //}
                  }
                  //else
                       if (NomT.Text == "" || ApepT.Text == "" || ApemT.Text == ""   || IdCT.Text == "" || IdET.Text == "")
                       {//Si hay campos vacios por llenar, obligar a llenarlos. Sino no se almacena nada
                            MessageBox.Show("Campos vacios");
                       }
                       else
                            //Elegir la ruta para guardar 
                            try //Excepcion para verificar que la imagen no existe y no cuase errores.
                            {
                                 Datos_Cliente.Nombre = NomT.Text.Trim();
                                 Datos_Cliente.Apellido_Paterno = ApepT.Text.Trim();
                                 Datos_Cliente.Apellido_Materno = ApemT.Text.Trim();
                                 Datos_Cliente.Telefono = TelT.Text.Trim();
                                 Datos_Cliente.Correo = CorreoT.Text.Trim();
                                 Datos_Cliente.Fecha = fecha.Value.Year + "/" + fecha.Value.Month + "/" + fecha.Value.Day;
                                 Datos_Cliente.Cliente_ID = Convert.ToInt32(IdCT.Text);
                                 Datos_Cliente.Entrenador_ID = Convert.ToInt32(IdET.Text);
                                 /*Elegir la ruta en la que se guarda la imagen y que se nombre automaticamente dependiendo del campo Codigo. */
                                 if (client.personaRegistrada(Convert.ToInt32(IdCT.Text)) == 0)
                                 {
                                      guardar.FileName = "C:\\\\\\Users\\\\\\Public\\\\\\FOTOS\\\\\\CLIENTES\\\\\\" + IdCT.Text + ".jpg";
                                      foto.Save(guardar.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);


                                      Datos_Cliente.Foto_Url = guardar.FileName;

                                      int resultado = ClientesBD.Agregar(Datos_Cliente); //Instancia del retorno de la clase ClienteDB
                                      if (resultado > 0)//Si el resultado devuelto en la calse ClientesDB =1 (conexion exitosa y datos correctos) insertar datos a la base
                                      {//Insertar datos a la base y borrar los campos para volver a agregar datos.
                                           MessageBox.Show("Cliente Registrado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                           foto.Dispose();
                                           foto2.Dispose();
                                           NomT.Text = "";
                                           ApepT.Text = "";
                                           ApemT.Text = "";
                                           TelT.Text = "";
                                           CorreoT.Text = "";
                                           IdCT.Text = "";
                                           IdET.Text = "";
                                           pictureBox3.Image = null;
                                      }
                                      else
                                      {//Si algo falla en el proceso anterior por alguna razon, no permite insertar clientes e intentarlo denuevo.
                                           MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                      }
                                 }
                                 else
                                 {
                                      MessageBox.Show("No se puede guardar usuario, ya existe un  usuario con el ese id");
                                      IdCT.Text = "";
                                 }
                            }
                            catch
                            { //en caso de no seleccionar un nombre valido a la imagen o nulo, no pasa nada y no se insertan datos.

                            }


             }




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
        {//Vaciar campos y cuadro de foto para llenar datos denuevo
            pictureBox3.Image = null;
            NomT.Text = null;
            ApepT.Text = null;
            ApemT.Text = null;
            TelT.Text = null;
            CorreoT.Text = null;
            IdCT.Text = null;
            IdET.Text = null;
            if (foto != null)
            {
                foto = null;
                foto2 = null;

            }

        }

        private void IniciarC_Click(object sender, EventArgs e)
        {//Iniciar la captura de video dependiendo del dispositivo seleccionado en el ComboBox
            videoSourcePlayer1.VideoSource = fuente;
            videoSourcePlayer1.Start();

        }

        private void AgregarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {//Al cerrar  el form, vaciar todos los campos.
            try
            {
                NomT.Text = null;
                ApepT.Text = null;
                ApemT.Text = null;
                TelT.Text = null;
                CorreoT.Text = null;
                IdCT.Text = null;
                IdET.Text = null;


            }
            catch
            {

            }

        }

        private void AgregarClientes_FormClosed(object sender, FormClosedEventArgs e)
        {//Antes de que se cancele el proyecto, detener la captura de video y despues, se cierra el proyecto.
            try
            {
                videoSourcePlayer1.SignalToStop();
                pictureBox1.Image = null;

            }
            catch { }


        }

        private void IdCT_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdCT_KeyPress(object sender, KeyPressEventArgs e)
        {//Validacion del campo Codigo, para solo insertar numeros, (Los espacios tampoco son válidos)
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void IdET_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion del campo Codigo, para solo insertar numeros, (Los espacios tampoco son válidos)
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TelT_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion del campo Codigo, para solo insertar numeros, (Los espacios tampoco son válidos)
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void entrenador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerB_Click(object sender, EventArgs e)
        {

        }

        private void AgregarB_Click(object sender, EventArgs e)
        {
        }

        private void entrenador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             IdET.Text = entrenador.CurrentRow.Cells["Entre_ID"].Value.ToString();

        }
    }
}
