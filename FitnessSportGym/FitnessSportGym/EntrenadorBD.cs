using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FitnessSportGym
{
     class EntrenadorBD
     {
          //se crean los objetos msql cmd para realizar el comando de sql
          //y el dr hace lectura de los  datos
          MySqlCommand cmd;
          MySqlDataReader dr;

          //metodo que resive los parametros de registrar entrenador y los incerta en entrenador 
          public string instentre(int id, string nombre, string apellido, string telefono, int tipo, string url) //falta la foto
          {
               string salida = "Se inserto un nuevo entrenador";
               try
               {
                    cmd = new MySqlCommand("insert into entrenador (Nombre,Apellidos,Telefono,Entre_ID,Tipo,Foto) values ('" + nombre + "','" + apellido + "','" + telefono + "',"+id+"," + tipo + ",'" + url + "')", ConectarBD.ObtenerConexion());
                    cmd.ExecuteNonQuery();
               }
               catch (Exception ex)
               {
                    salida = "no se inserto el entrenador: " + ex.ToString();
               }
               return salida;
          }

          //metodo que incerta el nombre y contraseña en la tabla usuarios de los entrenadores
          public string instusuarios(int id, int tipo, string nombre, string contra)
          {
               string salida = "Se inserto su usuario";
               try
               {
                    cmd = new MySqlCommand("insert into usuarios (idusuarios,usuario,contraseña,tipo) values (" + id + ",'" + nombre + "','" + contra + "'," + tipo + ")", ConectarBD.ObtenerConexion());
                    cmd.ExecuteNonQuery();
               }
               catch (Exception ex)
               {
                    salida = "no se inserto el usuario: " + ex.ToString();
               }
               return salida;
          }


          //verifica por medio de la id si el instructor ya tiene el mismo id que otro
          public int verificacioninstructor(int id)
          {
               int contador = 0;
               try
               {
                    cmd = new MySqlCommand("Select * From entrenador where Entre_ID=" + id + "", ConectarBD.ObtenerConexion());
                    //ejecuta el el comtando y lo lee de sql
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                         //leera los datos y te devolvera un falso o un verdadero si se encuentra un repetido
                         contador++;
                    }
                    dr.Close();
               }
               catch (Exception ex)
               {
                    MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
               }
               return contador;
          }
     }
}
