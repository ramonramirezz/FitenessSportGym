using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace FitnessSportGym
{
     class UsuarioBD
     {
          //Objetos mysql y objeto administrador
          Admin AD = new Admin();
         
          MySqlDataAdapter adp;
          MySqlCommand cmd;
          MySqlCommand type;
          MySqlDataReader dr;
          MySqlDataReader dr1;
          //Usuario y contraseña para dministrador universal
          string use = "admin";
          string con = "admin";

          //Metodo de verificacion de usuario resive los parametros del login
          public int verificacion(string usuario, string contraseña)
          {
               int status = 0;
               //revisa si es administrador universal
               if (usuario == use && contraseña == con)
               {
                    AD.Show();
               } if (usuario == "" || contraseña == ""){
                    MessageBox.Show("Algun campor es bacio");
               }
               else
               {
                    try
                    {
                         //Hace la consulta de que se cumpla los parametros del tipo de usuario
                         cmd = new MySqlCommand("select * from usuarios where usuario='" + usuario + "' and contraseña='" + contraseña + "'and tipo ='" + 1 + "' ;", ConectarBD.ObtenerConexion());
                         type = new MySqlCommand("select * from usuarios where usuario='" + usuario + "' and contraseña='" + contraseña + "'and tipo ='" + 2 + "' ;", ConectarBD.ObtenerConexion());
                         //Lee el comando y ejecuta
                         dr = cmd.ExecuteReader();
                         dr1 = type.ExecuteReader();
                              
                         int contador = 0;
                         int cont = 0;
                         while (dr.Read()) //Para usuario tipo 1
                         {
                              contador++;
                         }
                         while (dr1.Read()) //Para usuario tipo 2
                         {
                              cont++;
                              
                         } 
                         if (contador == 1)
                         {

                              AD.Show(); // Abre la ventana administrador

                              //usuario.Text = "";
                              //contra.Text = "";
                         }
                         else
                         {

                         
                         if (cont == 1)
                         {
                             // Ent.ShowDialog(); //Abre ventana entrenador


                              status = cont;
                              //usuario.Text = "";
                              //contra.Text = "";
                              
                         }
                         else if (contador > 1 || cont > 1)
                         {
                              MessageBox.Show("Duplicaste usuario y contraseña");
                         }
                         else //Hay un semi problema revisar el contador
                         {
                              MessageBox.Show("usuario o contraseña es incorrecta");
                              //cn.Close();
                              //cn1.Close();
                         }
                    }
                         
                         
                         
                    } 
                    catch (Exception ex)
                    {
                         MessageBox.Show("Error: " + ex.ToString());
                    }
               }

               return status;  
          } //cierre del metodo

          public MySqlCommand  sesion( string user, string contra)
          {
               MySqlCommand leer = new MySqlCommand("select idusuarios from usuarios where usuario='" + user + "' and contraseña='" + contra + "' ;", ConectarBD.ObtenerConexion());
              

               return leer;
          }

     }
}
