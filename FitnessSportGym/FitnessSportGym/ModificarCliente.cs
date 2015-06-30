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
     public partial class ModificarCliente : Form
     {
          ClientesBD client = new ClientesBD();

          string newruta;
          int status = 0;
          public ModificarCliente()
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

          private void IniciarC_Click(object sender, EventArgs e)
          {//Iniciar la captura de video dependiendo del dispositivo seleccionado en el ComboBox
            videoSourcePlayer1.VideoSource = fuente;
            videoSourcePlayer1.Start();
            status = 1;
          }

          private void CapturarC_Click(object sender, EventArgs e)
          {
               //Capturar el Frame actual del video al ser presionado y mostrarlo en el picturebox
               pictureBox3.Image = videoSourcePlayer1.GetCurrentVideoFrame(); //Presentar la imagen capturada en el picturebox
               foto2 = videoSourcePlayer1.GetCurrentVideoFrame();
               foto = foto2;
          }

          private void EliminarC_Click(object sender, EventArgs e)
          {
                         pictureBox3.Image = null;

            if (foto != null)
            {
                foto = null;
                foto2 = null;

            }

        }

          private void GuardarB_Click(object sender, EventArgs e)
          {
               Cliente Datos_Cliente = new Cliente();
               

                //Elegir el formato en el cual se guarda la imagen


               if(status == 1){ //cambiar imagen
                    guardar = new SaveFileDialog();
                    guardar.Filter = "Imagenes JPG | .jpg";

                    guardar.FileName = "C:\\\\\\Users\\\\\\Public\\\\\\FOTOS\\\\\\CLIENTES\\\\\\" + IdCT.Text + ".jpg";
                    foto.Save(guardar.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                    string url = guardar.FileName;

                    if (NomT.Text == "" || ApepT.Text == "" || IdCT.Text == "" || IdET.Text == "")
                    {//Si hay campos vacios por llenar, obligar a llenarlos. Sino no se almacena nada
                         MessageBox.Show("Campos vacios");
                    }
                    else
                         //Elegir la ruta para guardar 
                         try //Excepcion para verificar que la imagen no existe y no cuase errores.
                         {

                              MySqlCommand cmd = new MySqlCommand("Update cliente set Nombre = '" + NomT.Text + "', Apellido_Paterno = '" + ApepT.Text + "',Telefono = '" + TelT.Text + "', Correo = '" + CorreoT.Text + "',Entrenador_ID = '" + Convert.ToInt32(IdET.Text) + "' Foto = '" + url + "' where Cliente_ID = '" + Convert.ToInt32(IdCT.Text) + "';", ConectarBD.ObtenerConexion());
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Se a actualizado el usuario");
                              status = 0;
                              this.Close();

                         }
                         catch (Exception ex)
                         { //en caso de no seleccionar un nombre valido a la imagen o nulo, no pasa nada y no se insertan datos.
                              MessageBox.Show("Error " + ex.ToString());
                         }
                    
               }
               else //Imagen actual
               {           
               //Asegurar la ruta valida           
              
                    if (NomT.Text == "" || ApepT.Text == ""  || IdCT.Text == "" || IdET.Text == "")
                    {//Si hay campos vacios por llenar, obligar a llenarlos. Sino no se almacena nada
                         MessageBox.Show("Campos vacios");
                    }
                    else
                        
                         //Elegir la ruta para guardar 
                         try //Excepcion para verificar que la imagen no existe y no cuase errores.
                         {
                              /*Elegir la ruta en la que se guarda la imagen y que se nombre automaticamente dependiendo del campo Codigo. */
                            
                              MySqlCommand cmd = new MySqlCommand("Update cliente set Nombre = '" + NomT.Text + "', Apellido_Paterno = '" + ApepT.Text + "',Telefono = '" + TelT.Text + "', Correo = '" + CorreoT.Text + "',Entrenador_ID = '" + Convert.ToInt32(IdET.Text) + "' where Cliente_ID = '" + Convert.ToInt32(IdCT.Text) + "';", ConectarBD.ObtenerConexion());
                              cmd.ExecuteNonQuery();
                              MessageBox.Show("Se a actualizado el usuario");
                              status = 0;
                              this.Close();                              
                         }
                         catch (Exception ex)
                         { //en caso de no seleccionar un nombre valido a la imagen o nulo, no pasa nada y no se insertan datos.
                              MessageBox.Show("Error " + ex.ToString());
                         }            
               }
          }

          private void entrenador_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               IdET.Text = entrenador.CurrentRow.Cells["Entre_ID"].Value.ToString();
          }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
               //Seleccionar los/el dispositivo(s) de video disponibles para hacer la captura de foto
               fuente = new VideoCaptureDevice(dispositivo[comboBox1.SelectedIndex].MonikerString);
          }
          string ruta;
          private void ModificarCliente_Load(object sender, EventArgs e)
          {
   
               dispositivo = new FilterInfoCollection(FilterCategory.VideoInputDevice); // Crear el objeto que identifica nuestros dispositivos capaces de capturar video.
               //Iniciar la captura y toma de video en este campo. Del cual se tomara la foto.

               foreach (FilterInfo x in dispositivo)
               { // Seleccionar los diferentes dispositivos que tenemos para capturar video
                    comboBox1.Items.Add(x.Name); //Mostrar el nombre del dispositivo para capturar videos.
                    ;
               }
               comboBox1.SelectedIndex = 0;
          }

          private void ModificarCliente_FormClosing(object sender, FormClosingEventArgs e)
          {
               //Al cerrar  el form, vaciar todos los campos.
               try
               {
                    NomT.Text = null;
                    ApepT.Text = null;
                    TelT.Text = null;
                    CorreoT.Text = null;
                    IdCT.Text = null;
                    IdET.Text = null;
                    pictureBox3.Image = null;

               }
               catch
               {

               }
          }

          private void ModificarCliente_FormClosed(object sender, FormClosedEventArgs e)
          {
               //Antes de que se cancele el proyecto, detener la captura de video y despues, se cierra el proyecto.
               try
               {
                    videoSourcePlayer1.SignalToStop();
                    pictureBox1.Image = null;

               }
               catch { }
          }
     }
}
