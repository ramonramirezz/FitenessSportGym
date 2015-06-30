using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace FitnessSportGym
{
    public partial class Mensualidades : Form
    {
        public Mensualidades()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarB_Click(object sender, EventArgs e)
        {
             //Se evaluan y se almacenan en los string las fecha de entrada y de salida de los pickdatecalendar
             string fecha = fec.Value.Year + "/" + fec.Value.Month + "/" + fec.Value.Day;
             string fechaout = fecout.Value.Year + "/" + fecout.Value.Month + "/" + fecout.Value.Day;

             //Se hace una actualizacion a la base de datos de las fechas de salida y entrada de la tabla clientes y su mensualidad
             MySqlCommand cmd = new MySqlCommand("Update cliente set Fechain = '"+fecha+"', fechaout='"+fechaout+"', mensualidad="+CantidadT.Text+" where  Cliente_ID="+num.Text+";", ConectarBD.ObtenerConexion());
             cmd.ExecuteNonQuery();
             MessageBox.Show("Se a registrado su mensualidad");
             this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
