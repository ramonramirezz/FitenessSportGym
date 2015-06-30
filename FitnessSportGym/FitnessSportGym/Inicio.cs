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
    public partial class Inicio : Form
    {
         
         Cliente clint = new Cliente();
         

         public string User;
         public string Psw;
         // Variables Globales que almaneceran el usuario y contrasenia

         GetDatos gd = new GetDatos();
        public Inicio()
        {
            InitializeComponent();
            
        }

        public void AccederB_Click(object sender, EventArgs e)
        {
             UsuarioBD ubd = new UsuarioBD();
             //Se guarada lo que contenga los texbox en las variables globales
             User = UsuarioT.Text;
             Psw = ContraseñaT.Text;
          
             //Se le enviare a la clase usuariosDB  al metodo verificacion el usuario y contrasenia
             //para realizar si efectivamente es un usuario registrado
             int status = ubd.verificacion(User, Psw);
             Entrenador entre = new Entrenador(User, Psw);

             //Si el satus que nos devolvio del metodo anterior es 1 significa
             //que efectivamente es un usuario registrado y se abrira la pantalla entrenador
             if (status == 1)
             {               
                  entre.Show();
                  UsuarioT.Text = "";
                  ContraseñaT.Text = "";
             }else

                  //Se borra los campos de los texbox
             UsuarioT.Text = "";
             ContraseñaT.Text = "";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }

        private void timer_Tick(object sender, EventArgs e)
        {
             Reloj.Text = DateTime.Now.ToLongTimeString(); //inicializacion del reloj
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
             Application.Exit();
        }

        private void BuscarB_Click(object sender, EventArgs e)
        {
             //Se abrira la pantalla buscador para el cliente
             Buscador buscar = new Buscador();
             buscar.Show();
           
        }

        private void ContraseñaT_KeyPress(object sender, KeyPressEventArgs e)
        {

             //Si el usuario preesiona enter al finalizar su contrasenia hara lo mismo que el boton acceder
              if (e.KeyChar == Convert.ToChar(Keys.Enter))
              {
                   UsuarioBD ubd = new UsuarioBD();
                   User = UsuarioT.Text;
                   Psw = ContraseñaT.Text;


                   int status = ubd.verificacion(User, Psw);
                   Entrenador entre = new Entrenador(User, Psw);
                   if (status == 1)
                   {
                        entre.Show();
                        UsuarioT.Text = "";
                        ContraseñaT.Text = "";
                   }
                   else


                        UsuarioT.Text = "";
                   ContraseñaT.Text = "";
              }

        }

    }
}
