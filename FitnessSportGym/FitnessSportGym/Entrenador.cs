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
    public partial class Entrenador : Form
    {
         int dias;
         int id;
         MySqlDataReader dr;
         MySqlCommand cmd = new MySqlCommand();

         public void pintar(DataGridView dgv)
         {
              dgv.RowsDefaultCellStyle.BackColor = Color.Red; //metodo que pinta la fila del datagridview
         }
        public Entrenador(string pUser, string pPsw)
        {
             //obtiene los valores del usuario y su contrase;a
             this.User = pUser;
             this.Pass = pPsw;
            InitializeComponent();
            encontrarid();

        }

        public string User;
        public string Pass;

        public void encontrarid()
        {
             Cliente cd = new Cliente();
             UsuarioBD user = new UsuarioBD();
             GetDatos gd = new GetDatos();
             //Se resive la la consulta de la id del entrenador
            cmd = user.sesion(User, Pass);
            dr = cmd.ExecuteReader();
             //Se almacena la id en un entero
             while(dr.Read()){
                  id = dr.GetInt32(0);
             }            
        }
           

       
         

        private void AClientesB_Click(object sender, EventArgs e)
        {
             //Se abre la pantalla agregar cliente
             AgregarClientes client = new AgregarClientes();
             client.ShowDialog();
        }

        private void VClientesB_Click(object sender, EventArgs e)
        {
             //SE hace la consulta particular de los clientes dependiendo de la id del entrenador
             DataTable dtDatos = new DataTable();
             MySqlDataAdapter dt = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Correo,Telefono,Foto,Fechain,fechaout From cliente where Entrenador_ID = " + id + " and DATEDIFF(FECHAOUT,CURDATE()) > 0;", ConectarBD.ObtenerConexion());
             dt.Fill(dtDatos);
             registro.DefaultCellStyle.BackColor = Color.White;
             registro.DataSource = dtDatos;
        }

        private void VentasB_Click(object sender, EventArgs e)
        {
             //Se abre la pantalla agregar venta
             AgregarVentas venta = new AgregarVentas();
             venta.ShowDialog();
        }

        private void Entrenador_Load(object sender, EventArgs e)
        {

             try
             {
                  string ruta = "C:\\\\\\Users\\\\\\Public\\\\\\FOTOS\\\\\\ENTRENADOR\\\\\\" + id + ".jpg"; //Tomar la ruta del campo URL
                  Imagen.Image = Image.FromFile(ruta); //Mostrar la imagen de la ruta seleccionada
             }
             catch
             {
                  MessageBox.Show("no se encontro la imagen");
             }
        }

        private void registro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
             {
                  string ruta = Convert.ToString(registro.CurrentRow.Cells[5].Value); //Tomar la ruta del campo URL
                  ImagenC.Image = Image.FromFile(ruta); //Mostrar la imagen de la ruta seleccionada
             }
             catch
             {
                  MessageBox.Show("no se encontro la imagen");
             }
        }

        private void BuscarB_Click(object sender, EventArgs e)
        {

             //Resive los dias que le faltan para pagar la mensualidad del cliente
             dias = Status.status(Convert.ToInt32(numb.Text));
             if(dias <= 0){//Se pintara de rojo si sus dias que le fgaltan son 0 o menores

                  registro.RowsDefaultCellStyle.BackColor = Color.Red;
                  try
                  {
                       //Se hace la consulta de los clientes de ese entrenadr
                       DataTable dtDatos = new DataTable();
                       MySqlDataAdapter dt = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Correo,Telefono,Foto,Fechain,fechaout,mensualidad From cliente where  Entrenador_ID = " + id + " and (Nombre = '" + NombreT.Text + "' or Cliente_ID = '" + numb.Text + "');", ConectarBD.ObtenerConexion());
                       dt.Fill(dtDatos);
                       registro.DataSource = dtDatos;
                  }
                  catch (Exception ex)
                  {
                       MessageBox.Show("Cliente no encontrado");
                  }
             }
             else
             {
                  //Sino se pintta de blanco
                  registro.RowsDefaultCellStyle.BackColor = Color.White;
                  try
                  {
                       //Trae el cliente consultado de ese entrenador
                       DataTable dtDatos = new DataTable();
                       MySqlDataAdapter dt = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Correo,Telefono,Foto,Fechain,fechaout,mensualidad From cliente where  Entrenador_ID = " + id + " and (Nombre = '" + NombreT.Text + "' or Cliente_ID = '" + numb.Text + "');", ConectarBD.ObtenerConexion());
                       dt.Fill(dtDatos);
                       registro.DataSource = dtDatos;
                  }
                  catch (Exception ex)
                  {
                       MessageBox.Show("Cliente no encontrado");
                  }
             }
             


        }

        private void SalirB_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
             //Se abre la pantalla mensualidad
             Mensualidades mes = new Mensualidades();
             mes.ShowDialog();
        }

        public void button2_Click(object sender, EventArgs e)
        {   

        }

        private void LimpiarB_Click(object sender, EventArgs e)
        {
             //Limpia todos los campor de la imagen datagridview y nombre y cliente
             ImagenC.Image = null;
             registro.DataSource = null;
             numb.Text = null;
             NombreT.Text = null;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
             DataTable dtDatos = new DataTable();
             MySqlDataAdapter dt = new MySqlDataAdapter("Select Cliente_ID,Nombre,Apellido_Paterno,Correo,Telefono,Foto,Fechain,fechaout From cliente where Entrenador_ID = " + id + "  and DATEDIFF(FECHAOUT,CURDATE()) <= 0;", ConectarBD.ObtenerConexion());
             dt.Fill(dtDatos);
             registro.DefaultCellStyle.BackColor = Color.Red;     
             registro.DataSource = dtDatos;
        }

    }
}
