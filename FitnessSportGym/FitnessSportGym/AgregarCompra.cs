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
    public partial class AgregarCompra : Form
    {
        public AgregarCompra()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GuardarB_Click(object sender, EventArgs e)
        {
             compras pros = new compras();
            pros.Producto = prod.Text.Trim();
            pros.Cantidad = cant.Text.Trim();
            pros.Fecha = fec.Value.Year + "/" + fec.Value.Month + "/" + fec.Value.Day;
            pros.Proveedor = prov.Text.Trim();
            pros.Total = tot.Text.Trim();



            if (prod.Text == "" || cant.Text == ""  || prov.Text == "" || tot.Text=="")
            {//Si hay campos vacios por llenar, obligar a llenarlos. Sino no se almacena nada
                MessageBox.Show("Campos vacios", "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                int resultado = VentasBD.Agregar2(pros);
                if (resultado > 0)//Si el resultado devuelto en la calse ClientesDB =1 (conexion exitosa y datos correctos) insertar datos a la base
                {//Insertar datos a la base y borrar los campos para volver a agregar datos.
                    MessageBox.Show("Compra Registrada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    prod.Text = "";
                    cant.Text = "";
                    prov.Text = "";
                    tot.Text = "";

                }
                else
                {

                    //Si algo falla en el proceso anterior por alguna razon, no permite insertar clientes e intentarlo denuevo.
                    MessageBox.Show("No se pudo guardar la Compra", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }
        }
    }

