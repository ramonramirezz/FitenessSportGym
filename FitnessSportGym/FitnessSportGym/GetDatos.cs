using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessSportGym
{
    public class GetDatos
     {
        //Variables Globales para la contrasenia y usuario del entrenador
          public string Usuario { get; set; }
          public string Contraseña { get; set; }


          public GetDatos() { }



          public GetDatos(string pusuario,string pcontraseña)
          {
             //resive los valores y los guarda los valores en las variables globales
               //para luego usar su contenido
               this.Usuario = pusuario;
               this.Contraseña = pcontraseña;



          }
         
        
     }

}