using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfez
{
    public partial class CompraVenta : Form
    {
        public CompraVenta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool tx = true;
            Inicio ini = new Inicio(tx);
            this.Hide();
            ini.ShowDialog();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            ComprarInsumo comprainsumo = new ComprarInsumo();
            comprainsumo.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturas factura = new Facturas();
            factura.Show();

            this.Hide();
        }
    }
}
