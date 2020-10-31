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
    public partial class NuevoProducto : Form
    {
        public NuevoProducto()
        {
            InitializeComponent();
        }



        // Función de carga de datos en tabla stock
        private void button1_Click(object sender, EventArgs e)
        {



            string producto, codigo, categoria, descripcion, comentario;

            producto = textBox2.Text;
            codigo = textBox3.Text;
            categoria = textBox6.Text;
            descripcion = textBox4.Text;
            comentario = textBox5.Text;
            
            int cantidad = Int32.Parse(textBox8.Text);
            
            
            float precioCompra = float.Parse(textBox7.Text);

            Item i = new Item();

            if (i.AgregarItem(producto, codigo, categoria, descripcion, comentario, precioCompra, cantidad) == true)
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
            Stock stock = new Stock();
            this.Hide();
            stock.ShowDialog();
        }

       
    }
}
