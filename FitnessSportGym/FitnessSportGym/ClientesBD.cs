using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FitnessSportGym
{
    class ClientesBD
    {
         //Metodo Agregar Cliente con sus respectivos Datos
         public static int Agregar(Cliente Datos_Cliente)
         {

              //Iniciar el valor a retornar en 0, es decir Enviar un error.
              int retorno = 0;
              //Instanciar el comando que realizara la funcion de insertar los datos en la tabla.
              /*
               Formato de la insercion: Insertar en "Nombre de Tabla" (campo1, campo2,campo3... etc) Valores de los parametros que requiere el metodo.
               * Por ejmplo Datos_Cliente.nom es  la posicion {0} ya que es el primer campo de la tabla.
               * Estos parametros se obtienen en la clase Clientes, en donde se declaran las variables a insertar.
               */
              try
              {
                   MySqlCommand comando = new MySqlCommand(String.Format("insert into cliente (Nombre,Apellido_Paterno,Apellido_Materno,Telefono,Correo,Cliente_ID,Entrenador_ID,Foto,Fechain,fechaout) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',DATE_ADD(fechain, INTERVAL 1 MONTH))",
                    Datos_Cliente.Nombre, Datos_Cliente.Apellido_Paterno, Datos_Cliente.Apellido_Materno, Datos_Cliente.Telefono, Datos_Cliente.Correo, Datos_Cliente.Cliente_ID, Datos_Cliente.Entrenador_ID, Datos_Cliente.Foto_Url, Datos_Cliente.Fecha), ConectarBD.ObtenerConexion());
                   retorno = comando.ExecuteNonQuery();
                  
                   //Devolver retorno, 1= si la insercion fue exitosa, 0 si hubo errores.



              }
              catch (Exception ex)
              {
                   MessageBox.Show("Error al incertar " + ex.ToString());
              }

              return retorno;
         }

         public int personaRegistrada(int id)
         {
              int contador = 0;
              try
              {
                   MySqlCommand cmd = new MySqlCommand("Select * From cliente where Cliente_ID=" + id + "", ConectarBD.ObtenerConexion());
                   MySqlDataReader dr;
                   dr = cmd.ExecuteReader();
                   while (dr.Read())
                   {
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
         public static List<Cliente> Consultar(string pNombre, string pApep, string pApem)
         {/*
          * Este metodo, lo que hara es Generar una lista con todos los datos de la tabla, los cuales contengan algun dato igual al escrito en los campos de texto.ç
          * Esta metodo, requiere 3 entradas: un nombre, un apellido paterno y uno materno.
          * En abse a esos 3 datos, se hara la busqueda en toda la base.
          
          */
              List<Cliente> Consultar = new List<Cliente>(); //Generacion de la Lista en base a los datos semejantes

              MySqlCommand _comando = new MySqlCommand(String.Format(//Comando sql para hacer la busqueda en base a nombre y apellidos.

             "SELECT Nombre,Apellido Paterno,Apellido Materno,Telefono,Correo,Cliente_ID,Entrenador_ID,Foto FROM cliente  where Nombre='{0}' or Apellido Paterno='{1}' or Apellido Materno='{2}' ", pNombre, pApep, pApem), ConectarBD.ObtenerConexion());
              MySqlDataReader _reader = _comando.ExecuteReader(); //En esta linea se ejecuta la busqueda 
              while (_reader.Read())
              { /*
               * Lo que hace este apartado es lo siguiente:
               * Genera una lista con todos los campos de la base de datos , tomando como referencia los datos llenados en los campos
               * Se va a repetir el proceso  hasta encontrar todos los parecidos entre los filtros y la info. encontrada en la base de datos.
               * Ejemplo: Se busca el nombre: Ricardo, Apellido: Quijada <3 
               * Resultado de busqueda: Todos aquellos registros en los cuales el nombre=Ricardo ó Apellido= Quijada<3
               * Cuando se terminen de encontrar todos los datos, se cierra el ciclo y finaliza la busqueda.
               */
                   Cliente pCliente = new Cliente();
                   pCliente.Nombre = _reader.GetString(0);
                   pCliente.Apellido_Paterno = _reader.GetString(1);
                   pCliente.Apellido_Materno = _reader.GetString(2);
                   pCliente.Telefono = _reader.GetString(3);
                   pCliente.Correo = _reader.GetString(4);
                   pCliente.Cliente_ID = _reader.GetInt32(5);
                   pCliente.Entrenador_ID = _reader.GetInt32(6);
                   pCliente.Foto_Url = _reader.GetString(7);
                   Consultar.Add(pCliente);
              }
              //Devuelve la lista de datos obtenida, que será insertada en un DataGridView para poder visualizarse.
              return Consultar;

         }
    }
}
