using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessSportGym
{
    class Venta
    {
         //Variables globales para los parametros de ventas
        public string Producto { get; set; }
        public string Cantidad { get; set; }
        public string Fecha { get; set; }

        public string Total { get; set; }

        public Venta() { }

        public Venta(string pId, string can, string Fec, string total)
        {
             //Resive los campos de la pantalla venta y los almacena en las variables globales
            this.Producto = pId;
            this.Cantidad = can;
            this.Fecha = Fec;
            this.Total = total;
        }
           
    }
}
