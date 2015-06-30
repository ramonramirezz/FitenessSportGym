using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace FitnessSportGym
{
     class Status
     {
          // Metodo que resivira la id del cliente  para buscarlo en la base de datos
          // para hacer si su status de su mensualidad esta vigente
          public static int status(int id)
          {
               int dias = 0;

                    MySqlCommand stat = new MySqlCommand("SELECT DATEDIFF(FECHAOUT,CURDATE()) AS Tequedan_dias FROM cliente where Cliente_ID = " + id + ";", ConectarBD.ObtenerConexion());
                    MySqlDataReader rd = stat.ExecuteReader();
                   
                    while (rd.Read())
                    {
                         dias = rd.GetInt32(0);
                    }

                 //ya hecha la resta de las fechas de su fecha de salida y la fecha de hoy lo convierte
               //a entero para devolverlo a la clase buscador al metodo keypress
               return dias;
          }

     }
}
