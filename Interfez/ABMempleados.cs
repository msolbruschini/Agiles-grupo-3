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
    public partial class ABMempleados : Form
    {
        public ABMempleados()
        {
            InitializeComponent();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            bool tx = true;
            Inicio ini = new Inicio(tx);
            this.Hide();
            ini.ShowDialog();
        }

        private void ABMempleados_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            Empleado emp = new Empleado();
            DS = emp.MostrarEmpleado();
            dataGridView1.DataSource = DS.Tables[0];
        }
    }

       
    
}
