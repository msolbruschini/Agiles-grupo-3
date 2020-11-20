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
    public partial class CompraInsumo : Form
    {
        public CompraInsumo()
        {
            InitializeComponent();
            DataSet DS = new DataSet();
            Item i = new Item();
            DS = i.MostrarItemBajo();
            dataGridView1.DataSource = DS.Tables[0];
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

        private void CompraInsumo_Load(object sender, EventArgs e)
        {

        }
    }
}
