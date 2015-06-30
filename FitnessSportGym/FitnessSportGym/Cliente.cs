using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessSportGym
{
    class Cliente
    {

        
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Foto_Url { get; set; }
        public int Cliente_ID { get; set; }

        public int Entrenador_ID { get; set; }

        public string Fecha { get; set; }

        public string us { get; set; }
        public string con { get; set; }

        public Cliente() { } //Constructor Vacio

        public Cliente(string pnom, string pap, string pam, string ptelefono, string pcorreo, int pcliente_id, int pentrenador_id, string purl, string fecha)
        { //Constructor LLeno
            /*
             * Instancia de las variables a llenar.
             * Es decir, las variables de este metodo, se llenaran con la informacion de la Forma de Registro.
             */
            
            this.Nombre = pnom;
            this.Apellido_Paterno = pap;
            this.Apellido_Materno = pam;
            this.Telefono = ptelefono;
            this.Correo = pcorreo;
            this.Cliente_ID = pcliente_id;
            this.Entrenador_ID = pentrenador_id;
            this.Foto_Url = purl;
            this.Fecha = fecha;
        }
    }
}
