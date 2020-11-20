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

        private void button1_Click(object sender, EventArgs e)
        {
            Facturascs factura = new Facturascs();
            factura.Show();
      
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool tx = true;
            Inicio ini = new Inicio(tx);
            this.Hide();
            ini.ShowDialog();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            CompraInsumo comprainsumo = new CompraInsumo();
            comprainsumo.Show();
            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gastos Gastos = new Gastos();
            Gastos.Show();
         
            this.Hide();
        }

        private void CompraVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
