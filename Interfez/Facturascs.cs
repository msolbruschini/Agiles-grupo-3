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
    public partial class Facturascs : Form
    {
        public Facturascs()
        {
            InitializeComponent();
           /*
            DataSet DS = new DataSet();
            Factura f = new Factura();
            DS = f.MostrarFactura();
            dataGridView1.DataSource = DS.Tables[0]; */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool tx = true;
            CompraVenta ini = new CompraVenta();
            this.Hide();
            ini.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = textBox1.Text;
            DataSet DS = new DataSet();
            Factura f = new Factura();
            DS = f.MostrarFacturaDesde(fecha);
            try
            {
                dataGridView1.DataSource = DS.Tables[0];
            }
            finally
            {

            }
            
        }
    }
}
