using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace FitnessSportGym
{
     public partial class Buscador : Form
     {
          int dias;
          public Buscador()
          {
               InitializeComponent();
          }
   
          //Evento del texbox para la funcionalidad del enter
          private void NumC_KeyPress(object sender, KeyPressEventArgs e)
          {
               //Si el usuario presiona enter entrara
               if (e.KeyChar == Convert.ToChar(Keys.Enter))
               {
                    //validacion que el usuario solo preiono enter pero sin escribir un numero
                    if(NumC.Text==""){
                         MessageBox.Show("No a ingresado numero");
                         cliente.DataSource = null;
                    }
                    else
                    { //Resivira del metodo satus de la clase Status los dias restantes de ese cliente
                         dias = Status.status(Convert.ToInt32(NumC.Text));
                         if(dias <= 0){ //si los dias son menures a 0 osea se le paso su mensualidad o son 0
                            //Pintara su celda de color rojo
                              cliente.RowsDefaultCellStyle.BackColor = Color.Red;
                              try
                              {
                                   //ara la consulta dependiendo del numero del cliente que ingreso y lo metara en un objeto tabla para mostrarlos en el datagridview
                                   DataTable dt = new DataTable();
                                   MySqlDataAdapter da = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Fechain,fechaout from cliente where Cliente_ID = " + NumC.Text + ";", ConectarBD.ObtenerConexion());
                                   da.Fill(dt);
                                   cliente.DataSource = dt;
                              }
                              catch (Exception ex) //Si hay algun proble al conectarse nos mostrara el un mensaje de error
                              {
                                   MessageBox.Show("Error al conectar");
                              }
                         }
                         else
                         { //si el cliente tiene la mensualidad activa lo pintara de color blanco y mostrara sus datos en el datagridview
                              cliente.RowsDefaultCellStyle.BackColor = Color.White;
                              try
                              {
                                   DataTable dt = new DataTable();
                                   MySqlDataAdapter da = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Fechain,fechaout from cliente where Cliente_ID = " + NumC.Text + ";", ConectarBD.ObtenerConexion());
                                   da.Fill(dt);
                                   cliente.DataSource = dt;
                              }
                              catch (Exception ex)
                              {
                                   MessageBox.Show("Error al conectar");
                              }
                         }

                    }
                    NumC.Text = null;
               }
          }


          //Eventos para inicializar el Reloj digital de la pantalla
          private void timer1_Tick(object sender, EventArgs e)
          {
               Reloj.Text = DateTime.Now.ToLongTimeString();
          }

          private void Buscador_Load(object sender, EventArgs e)
          {
               Reloj.Text = DateTime.Now.ToLongTimeString();
          }
     }
}
