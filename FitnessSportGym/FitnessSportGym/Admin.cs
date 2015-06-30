using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessSportGym
{
    public partial class Admin : Form
    {
         int dias;
         int status = 0;
        public Admin()
        {
            InitializeComponent();
        }

        

        private void ProductoB_Click(object sender, EventArgs e)
        {
             //Se abrira la pantalla agregar producto
            Agregar_Producto P = new Agregar_Producto();
            P.Show();
        }

        private void ComprasB_Click(object sender, EventArgs e)
        {
             //Se abrira la pantalla agregar compra
            AgregarCompra C = new AgregarCompra();
            C.Show();
        }

        private void VentasB_Click(object sender, EventArgs e)
        {
             //Se abrira la pantalla agregar una venta
            AgregarVentas V = new AgregarVentas();
            V.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=gym; Uid=root; pwd=;");
            /* Formato: direccion del servidor, Nombre de la base de datos, los otros dos campos se dejan igual por default.*/
            try
            { //Intentar establecer conexion con la base de datos.
                conectar.Close();


            }
            catch
            { //Si no se puede desconectar por algun motivo, mandar error de conexion.
                MessageBox.Show("Error");
            }
            //Devuelve al a pagina prncipal

            this.Close();
        }

        private void AEntrenador_Click(object sender, EventArgs e)
        {
             //SE abrira la pantalla agregar entrenador
            AgregarEntrenador E = new AgregarEntrenador();
            E.Show();
        }

        private void AClientesB_Click(object sender, EventArgs e)
        {
             //Se abrira la pantalla agregar cliente
            AgregarClientes C = new AgregarClientes();
            C.Show();
        }

        private void ComprasB1_Click(object sender, EventArgs e)
        {
            
        }

        private void ComprasB1_Click_1(object sender, EventArgs e)
        {
             //Se abrira el reporte de compras
          Reporte_Compras C1 = new Reporte_Compras();
            C1.ShowDialog();
        }

        private void ProductosB1_Click(object sender, EventArgs e)
        {
             //Se abrira la pantalla de reporte de productos
            ReporteProductosEnStock C = new ReporteProductosEnStock();
            C.ShowDialog();
        }

        private void VentasB1_Click(object sender, EventArgs e)
        {
             //Se abrira la pantalla reporte de ventas
            Reporte_Ventas C = new Reporte_Ventas();
            C.ShowDialog();
        }

         public void activo(){
              //Consultara todos los clientes que estar registrado en el gym y se mostraran 
              //en el datagridview
              try
              {
                   DataTable dtDatos = new DataTable();
                   MySqlDataAdapter dt = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Correo,Telefono,Foto,Fechain,fechaout,mensualidad From cliente where DATEDIFF(FECHAOUT,CURDATE()) > 0 ;", ConectarBD.ObtenerConexion());
                   dt.Fill(dtDatos);
                   registro.DefaultCellStyle.BackColor = Color.White;
                   registro.DataSource = dtDatos;
              }
              catch (Exception ex)
              {
                   MessageBox.Show("Error al consultar " + ex.ToString());
              }
              status = 0;
         }

         public void inactivo()
         {
              //Consultara todos los clientes que estar registrado en el gym y se mostraran 
              //en el datagridview vencidos
              try
              {
                   DataTable dtDatos = new DataTable();
                   MySqlDataAdapter dt = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Correo,Telefono,Foto,Fechain,fechaout,mensualidad From cliente where DATEDIFF(FECHAOUT,CURDATE()) <= 0;", ConectarBD.ObtenerConexion());
                   dt.Fill(dtDatos);
                   registro.DefaultCellStyle.BackColor = Color.Red;
                   registro.DataSource = dtDatos;
              }
              catch (Exception ex)
              {
                   MessageBox.Show("Error al consultar " + ex.ToString());
              }
         }
        private void VClientesB_Click(object sender, EventArgs e)
        {
             activo();
             status = 1;

        }

        private void VEntrenadores_Click(object sender, EventArgs e)
        {
             //Se hace la consulta a la base de datos de todos los entrenadores y se mostrara en el datagridview
             DataTable dtDatos = new DataTable();
             MySqlDataAdapter dt = new MySqlDataAdapter("Select Entre_ID,Nombre,Apellidos,Telefono,Tipo,Foto From entrenador;", ConectarBD.ObtenerConexion());
             dt.Fill(dtDatos);
             registro.DataSource = dtDatos;
        }

        private void BuscarB_Click(object sender, EventArgs e)
        {
             //Resivira del metodo satus de la clase Status los dias restantes de ese cliente
             dias = Status.status(Convert.ToInt32(numb.Text));
             if(dias <= 0){
                  //si los dias son menures a 0 osea se le paso su mensualidad o son 0
                  //Pintara su celda de color rojo
                  registro.DefaultCellStyle.BackColor = Color.Red;
                  try
                  {
                       //Se hace la seleccion dependiendo del numero del cliente que ingreso o el nombre y se mostrara en el datagridview
                       DataTable dtDatos = new DataTable();
                       MySqlDataAdapter dt = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Correo,Telefono,Foto,Fechain,fechaout From cliente where Nombre = '" + NombreT.Text + "' or Cliente_ID = " + numb.Text + ";", ConectarBD.ObtenerConexion());

                       dt.Fill(dtDatos);
                       registro.DataSource = dtDatos;

                  }
                  catch (Exception ex)
                  {
                       MessageBox.Show("Cliente no encontrado " + ex.ToString());
                  }
             }
             else
             {//Si no se pintara de color blando y tarera los datos del cliente buscados
                  registro.DefaultCellStyle.BackColor = Color.White;
                  try
                  {
                       DataTable dtDatos = new DataTable();
                       MySqlDataAdapter dt = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Correo,Telefono,Foto,Fechain,fechaout From cliente where Nombre = '" + NombreT.Text + "' or Cliente_ID = " + numb.Text + ";", ConectarBD.ObtenerConexion());

                       dt.Fill(dtDatos);
                       registro.DataSource = dtDatos;

                  }
                  catch (Exception ex)
                  {
                       MessageBox.Show("Cliente no encontrado " + ex.ToString());
                  }
             }


        }

        private void LimpiarB_Click(object sender, EventArgs e)
        {
             //Boton limpiar que limpiara todos los campor; datagridview, la imagen, y los texbox
             Imagen.Image = null;
             registro.DataSource = null;
             NombreT.Text = "";
             numb.Text = "";
        }

        private void registro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                string ruta = Convert.ToString(registro.CurrentRow.Cells[5].Value); //Tomar la ruta del campo URL
                Imagen.Image = Image.FromFile(ruta); //Mostrar la imagen de la ruta seleccionada
            }
            catch {
                MessageBox.Show("no se encontro la imagen");
            }
            }

        private void button1_Click_1(object sender, EventArgs e)
        {//Se abre la pantalla mensualidad
             Mensualidades mes = new Mensualidades();
             mes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             //Se abre la pantalla reporte de mendualidad
             ReporteMensualidades men = new ReporteMensualidades();
             men.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             inactivo();
        }
        
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ModificarCliente dat = new ModificarCliente();
             try
             {
                  dat.IdCT.Text = Convert.ToString(registro.CurrentRow.Cells[0].Value);
                  dat.NomT.Text = Convert.ToString(registro.CurrentRow.Cells[1].Value);
                  dat.ApepT.Text = Convert.ToString(registro.CurrentRow.Cells[2].Value);
                  dat.CorreoT.Text = Convert.ToString(registro.CurrentRow.Cells[3].Value);
                  dat.TelT.Text = Convert.ToString(registro.CurrentRow.Cells[4].Value);
                  try
                  {
                      string ruta = Convert.ToString(registro.CurrentRow.Cells[5].Value); //Tomar la ruta del campo URL
                      
                       dat.pictureBox3.Image = Image.FromFile(ruta); //Mostrar la imagen de la ruta seleccionada
                  }
                  catch
                  {
                       MessageBox.Show("no se encontro la imagen");
                  }
                  dat.IdCT.Enabled = false;
                  dat.Show();
             }catch(Exception ex){
                  MessageBox.Show("Error  " + ex.ToString());
             }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
             string id = Convert.ToString(registro.CurrentRow.Cells[0].Value);
             

             if(status != 0){
                  try
                  {
                       MySqlCommand cmd = new MySqlCommand("Delete from cliente where Cliente_ID = '" + Convert.ToInt32(id) + "';", ConectarBD.ObtenerConexion());
                       cmd.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                       MessageBox.Show("Problema al eliminar " + ex.ToString());
                  }
                  Imagen.Image = null;
                  activo();
             }
             else
             {
                  try
                  {
                       MySqlCommand cmd = new MySqlCommand("Delete from cliente where Cliente_ID = '" + Convert.ToInt32(id) + "';", ConectarBD.ObtenerConexion());
                       cmd.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                       MessageBox.Show("Problema al eliminar " + ex.ToString());
                  }
                  Imagen.Image = null;
                  inactivo();
             }
             
        }
        }
    }

