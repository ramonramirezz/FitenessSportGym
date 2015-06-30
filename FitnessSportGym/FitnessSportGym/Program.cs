using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessSportGym
{
    public class init : System.Windows.Forms.ApplicationContext
    {

        public init()
        {
           Inicio abrir = new Inicio();
            abrir.ShowDialog();
        }

    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new init());
        }
    }
}
