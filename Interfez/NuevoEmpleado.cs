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
    public partial class NuevoEmpleado : Form
    {
        public NuevoEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMempleados stock = new ABMempleados();
            this.Hide();
            stock.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, direccion;

            nombre = textBoxNyA.Text;
            direccion = textBoxDirec.Text;

            int dni = Int32.Parse(textBoxDNI.Text);
            int horas = Int32.Parse(textBoxHs.Text);
            int valorHs = Int32.Parse(textBoxVhs.Text);
            int sueldo = Int32.Parse(textBoxSueldo.Text);

            Empleado emp = new Empleado();

            if (emp.NuevoEmpleado(dni, nombre, direccion, horas, valorHs, sueldo) == true)
            {
                MessageBox.Show("El Empleado fue cargado con éxito");
            }
            else
            {
                MessageBox.Show("Error al cargar");
            }
        }

        private void textBoxSueldo_TextChanged(object sender, EventArgs e)
        {
            int horas = Int32.Parse(textBoxHs.Text);
            int valorHs = Int32.Parse(textBoxVhs.Text);
            int sueldo = horas * valorHs;
            textBoxSueldo.Text = sueldo.ToString();
        }
    }
}
