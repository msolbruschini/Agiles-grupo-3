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
    public partial class NuevoItem : Form
    {
        public NuevoItem()
        {
            InitializeComponent();
        }



        // Función de carga de datos en tabla stock
        private void button1_Click(object sender, EventArgs e)
        {



            string nombre, descripcion;

            nombre = textBox2.Text;
           
            descripcion = textBox6.Text;
           
            
            int cantidad = Int32.Parse(textBox5.Text);
            
            
            float precio = float.Parse(textBox8.Text);

            ItemMenu i = new ItemMenu();

            if (i.AgregarItem(nombre , descripcion, precio, cantidad) == true)
            {
                MessageBox.Show("El producto fue cargado con éxito");
            }
            else
            {
                MessageBox.Show("Error al cargar");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Menu stock = new Menu();
            this.Hide();
            stock.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
