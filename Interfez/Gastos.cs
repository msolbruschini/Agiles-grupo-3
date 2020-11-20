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
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            CompraVenta ini = new CompraVenta();
            this.Hide();
            ini.ShowDialog();
        }
    }
}
