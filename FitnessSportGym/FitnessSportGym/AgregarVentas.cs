using MySql.Data.MySqlClient;
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
    public partial class AgregarVentas : Form
    {
        public AgregarVentas()
        {
            InitializeComponent();
        }

        private void VerB_Click(object sender, EventArgs e)
        {
             //muetra el inventtario del gym que se encuentra en la tabla productos y se agregar en datagridview
            DataTable dtDatos = new DataTable();

            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("Select Nombre,PrecioparaVenta From productos;", ConectarBD.ObtenerConexion());

            mdaDatos.Fill(dtDatos);

            ver.DataSource = dtDatos;
        }

        private void AgregarB_Click(object sender, EventArgs e)
        {
             //Evalua si al darle agregar a un producto se muestran sus datos en los texbox correspondientes
            prod.Text = ver.CurrentRow.Cells["Nombre"].Value.ToString();
            pre.Text = ver.CurrentRow.Cells["PrecioparaVenta"].Value.ToString();
        }

        private void CalcularB_Click(object sender, EventArgs e)
        {
            double var1;
            double var2;
            double tota;
             //Convierte los valores de string a doble
            var1 = Convert.ToDouble(pre.Text);
            var2 = Convert.ToDouble(cant.Text);
            tota = var1 * var2;
            tot.Text = tota.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta pros = new Venta();
            pros.Producto = prod.Text.Trim();
            pros.Cantidad = cant.Text.Trim();
            pros.Fecha = fec.Value.Year + "/" + fec.Value.Month + "/" + fec.Value.Day;
            pros.Total = tot.Text.Trim();



            if (prod.Text == "" || cant.Text == "" || tot.Text == "")
            {//Si hay campos vacios por llenar, obligar a llenarlos. Sino no se almacena nada
                MessageBox.Show("Campos vacios", "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                int resultado = VentasBD.Agregar3(pros);
                if (resultado > 0)//Si el resultado devuelto en la calse ClientesDB =1 (conexion exitosa y datos correctos) insertar datos a la base
                {//Insertar datos a la base y borrar los campos para volver a agregar datos.
                    MessageBox.Show("Venta Registrada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    prod.Text = "";
                    pre.Text = "";
                    cant.Text = "";

                    tot.Text = "";

                }
                else
                {

                    //Si algo falla en el proceso anterior por alguna razon, no permite insertar clientes e intentarlo denuevo.
                    MessageBox.Show("No se pudo guardar la Venta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
