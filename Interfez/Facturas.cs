using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio2;

namespace Interfez
{
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool tx = true;
            CompraVenta ini = new CompraVenta();
            this.Hide();
            ini.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            DataSet DS = new DataSet();
            Factura f = new Factura();
            MessageBox.Show("Fecha seleccionada \n"
                + "Fecha: "
                + fecha

                );
            DS = f.MostrarFacturaDesde(fecha);
            //dataGridView1.DataSource = DS.Tables[0];

            if (dataGridView1.Rows.Count > 0)
            {



                dataGridView1.DataSource = DS.Tables[0];


            }
            else
            {
                MessageBox.Show("No hay ventas para esa fecha");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
