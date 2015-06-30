using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessSportGym
{
    class compras
    {

        public string Producto { get; set; }
        public string Cantidad { get; set; }
        public string Fecha { get; set; }

        public string Proveedor { get; set; }

        public string Total { get; set; }

        public compras() { }

        public compras(string p, string canti, string fech, string prove, string tot)
        {
            this.Producto = p;
            this.Cantidad = canti;
            this.Fecha = fech;

            this.Proveedor = prove;
            this.Total = tot;
        }
    }
}
