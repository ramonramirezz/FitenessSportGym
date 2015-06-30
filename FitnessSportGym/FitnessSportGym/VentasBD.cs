using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessSportGym
{
    class VentasBD
    {
        MySqlCommand cmd;
        MySqlDataReader dr;


        public static int Agregar(producto pr)
        {
            //Iniciar el valor a retornar en 0, es decir Enviar un error.
            int retorno = 0;
            //Instanciar el comando que realizara la funcion de insertar los datos en la tabla.
            /*
             Formato de la insercion: Insertar en "Nombre de Tabla" (campo1, campo2,campo3... etc) Valores de los parametros que requiere el metodo.
             * Por ejmplo Datos_Cliente.nom es  la posicion {0} ya que es el primer campo de la tabla.
             * Estos parametros se obtienen en la clase Clientes, en donde se declaran las variables a insertar.
             */
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into productos (IdProducto,Nombre,PrecioUnitario,PrecioparaVenta,Cantidad) values ('{0}','{1}','{2}','{3}','{4}')",
            pr.Id, pr.Nombre, pr.PrecioUnitario, pr.PrecioVenta, pr.Cantidad), ConectarBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            //Devolver retorno, 1= si la insercion fue exitosa, 0 si hubo errores.
            return retorno;
        }

        public static int Agregar2(compras pr1)
        {
            //Iniciar el valor a retornar en 0, es decir Enviar un error.
            int retorno = 0;
            //Instanciar el comando que realizara la funcion de insertar los datos en la tabla.
            /*
             Formato de la insercion: Insertar en "Nombre de Tabla" (campo1, campo2,campo3... etc) Valores de los parametros que requiere el metodo.
             * Por ejmplo Datos_Cliente.nom es  la posicion {0} ya que es el primer campo de la tabla.
             * Estos parametros se obtienen en la clase Clientes, en donde se declaran las variables a insertar.
             */
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into compra (Producto,Cantidad,Fecha_compra,Proveedor,Total) values ('{0}','{1}','{2}','{3}','{4}')",
            pr1.Producto, pr1.Cantidad, pr1.Fecha, pr1.Proveedor, pr1.Total), ConectarBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            //Devolver retorno, 1= si la insercion fue exitosa, 0 si hubo errores.
            return retorno;
        }

        public static int Agregar3(Venta pr2)
        {
            //Iniciar el valor a retornar en 0, es decir Enviar un error.
            int retorno = 0;
            //Instanciar el comando que realizara la funcion de insertar los datos en la tabla.
            /*
             Formato de la insercion: Insertar en "Nombre de Tabla" (campo1, campo2,campo3... etc) Valores de los parametros que requiere el metodo.
             * Por ejmplo Datos_Cliente.nom es  la posicion {0} ya que es el primer campo de la tabla.
             * Estos parametros se obtienen en la clase Clientes, en donde se declaran las variables a insertar.
             */
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into venta (Producto,Cantidad,Fecha,Total) values ('{0}','{1}','{2}','{3}')",
            pr2.Producto, pr2.Cantidad, pr2.Fecha, pr2.Total), ConectarBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            //Devolver retorno, 1= si la insercion fue exitosa, 0 si hubo errores.
            return retorno;
        } 
    }
}
