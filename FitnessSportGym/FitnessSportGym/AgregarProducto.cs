using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessSportGym
{
    public partial class Agregar_Producto : Form
    {
        public Agregar_Producto()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //se designan las variables y se les agrega el conetenido de los campos
            producto pro = new producto();
            pro.Id = ID.Text.Trim();
            pro.Nombre = Producto.Text.Trim();
            pro.PrecioUnitario = PrecioUni.Text.Trim();
            pro.PrecioVenta = PrecioVent.Text.Trim();
            pro.Cantidad = Cantidad.Text.Trim();

            if (ID.Text == "" || Producto.Text == "" || PrecioUni.Text == "" || PrecioVent.Text == "" || Cantidad.Text == "")
            {//Si hay campos vacios por llenar, obligar a llenarlos. Sino no se almacena nada
                MessageBox.Show("Campos vacios", "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                int resultado = VentasBD.Agregar(pro);
                if (resultado > 0)//Si el resultado devuelto en la calse ClientesDB =1 (conexion exitosa y datos correctos) insertar datos a la base
                {//Insertar datos a la base y borrar los campos para volver a agregar datos.
                    MessageBox.Show("Producto Registrado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ID.Text = "";
                    Producto.Text = "";
                    PrecioUni.Text = "";
                    PrecioVent.Text = "";
                    Cantidad.Text = "";

                }
                else
                {

                    //Si algo falla en el proceso anterior por alguna razon, no permite insertar clientes e intentarlo denuevo.
                    MessageBox.Show("No se pudo guardar el Producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
  