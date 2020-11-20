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
    public partial class DetalleProducto : Form
    {
        public DetalleProducto(int id)
        {
            InitializeComponent();
            DataSet DS = new DataSet();
            Item i = new Item();
            DS = i.MostrarDetalle(id);
            dataGridView1.DataSource = DS.Tables[0];
        }

        

        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            this.Hide();
            stock.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DetalleProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
