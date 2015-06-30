using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FitnessSportGym
{
    class ConectarBD
    {
        public static MySqlConnection ObtenerConexion()
        { //Metodo que me va a PERMITIR ENTRAR a la base de datos
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=gym; Uid=root; pwd=;");
            /* Formato: direccion del servidor, Nombre de la base de datos, los otros dos campos se dejan igual por default.*/
            try
            { //Intentar establecer conexion con la base de datos.
                conectar.Open();
              
            }
            catch
            { //Si no se puede conectar por algun motivo, mandar error de conexion.
                MessageBox.Show("Error de Conexion");
            }
            //Devolver el estatus de la conexion: 1= Exito, 0=Falla
            return conectar;

        }


    }
}
