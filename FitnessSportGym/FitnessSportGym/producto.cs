using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessSportGym
{
    class producto
    {
         //Variables globales para productos
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string PrecioUnitario { get; set; }
        public string PrecioVenta { get; set; }
        public string Cantidad { get; set; }

        public producto() { }

        public producto(string pId, string pNombre, string pPrecioUni, string pPrecioVent, string pCantidad)
        {
             //Resive los campos de la pantalla agregar producto y los almacenan en las variables globales
            this.Id = pId;
            this.Nombre = pNombre;
            this.PrecioUnitario = pPrecioUni;
            this.PrecioVenta = pPrecioVent;
            this.Cantidad = pCantidad;
        }
    
    }
}
