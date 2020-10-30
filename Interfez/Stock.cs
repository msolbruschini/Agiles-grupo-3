using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CapaNegocio2;

namespace Interfez
{



    public partial class Stock : Form
    {

        public Stock()
        {
            InitializeComponent();
        }


        private void Stock_Load(object sender, EventArgs e)
        {
          
            DataSet DS = new DataSet();
            Item i = new Item();
            DS = i.MostrarItem();
            dataGridView1.DataSource = DS.Tables[0];
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Relleno rell = new Relleno();
            this.Close();
            this.Dispose();
            rell.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                Refresh();
                if (!AgregarNuevo.Text.Trim().Equals(""))
                {
                    DataSet DS = new DataSet();
                    Item i = new Item();
                    DS = i.MostrarItemBuscado(AgregarNuevo.Text.Trim());
                    try
                    {
                        dataGridView1.DataSource = DS.Tables[0];
                    }
                    finally {
                    
                    }
                }

            }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0 )
            {
                string Categoria , Codigo , Producto , Cantidad , PrecioCompra , Id;
                int IdAux, CantidadAux;
                float PrecioCompraAux;


                Item i = new Item();
                Cantidad = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
                PrecioCompra = dataGridView1.CurrentRow.Cells["precioCompra"].Value.ToString();
                Categoria = dataGridView1.CurrentRow.Cells["categoria"].Value.ToString();
                Codigo = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                Producto = dataGridView1.CurrentRow.Cells["producto"].Value.ToString();
                Id = dataGridView1.CurrentRow.Cells["StockId"].Value.ToString();
                IdAux = int.Parse(Id);
                CantidadAux = int.Parse(Cantidad);
                PrecioCompraAux = float.Parse(PrecioCompra);


                if (i.ModificarItem(IdAux, Codigo, Producto, Categoria, PrecioCompraAux, CantidadAux) == true )
                { 
                    MessageBox.Show("La modificacion se realizo con exito");
                }
                else
                { 
                    MessageBox.Show("La modificacion no se pudo realizar");
                }
                DataSet DS = new DataSet();
                i = new Item();
                DS = i.MostrarItem();
                dataGridView1.DataSource = DS.Tables[0];

                
            }
            else
            {
                MessageBox.Show("Seleccione la fila modificar");
            }
                

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevo = new NuevoProducto();

            this.Hide();
            nuevo.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {  
            // Envia el id del producto seleccionado a la vista de DetalleProducto
            if (dataGridView1.SelectedRows.Count == 1)
            {

                
                int Id = Int32.Parse(dataGridView1.CurrentRow.Cells["StockId"].Value.ToString());
                DetalleProducto detalle = new DetalleProducto(Id);
                this.Hide();
                detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione Una fila para ver el producto");
            }
        }
    }
}
