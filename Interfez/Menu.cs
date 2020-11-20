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


    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }


        private void Stock_Load(object sender, EventArgs e)
        {
          
            DataSet DS = new DataSet();
            ItemMenu i = new ItemMenu();
            DS = i.MostrarItem();
            dataGridView1.DataSource = DS.Tables[0];
            
        }



        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void CrearProducto_Click(object sender, EventArgs e)
        {
            NuevoItem nuevo = new NuevoItem();
            this.Hide();
            nuevo.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Refresh();
            if (!AgregarNuevo.Text.Trim().Equals(""))
            {
                DataSet DS = new DataSet();
                ItemMenu i = new ItemMenu();
                DS = i.MostrarItemBuscado(AgregarNuevo.Text.Trim());
                try
                {
                    dataGridView1.DataSource = DS.Tables[0];
                }
                finally
                {

                }
            }
        }

        private void EditarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string descripcion, nombre, Cantidad, PrecioCompra, Id;
                int IdAux, CantidadAux;
                float PrecioAux;


                ItemMenu i = new ItemMenu();
                Cantidad = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
                PrecioCompra = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                nombre = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                descripcion = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                Id = dataGridView1.CurrentRow.Cells["codItem"].Value.ToString();
                IdAux = int.Parse(Id);
                CantidadAux = int.Parse(Cantidad);
                PrecioAux = float.Parse(PrecioCompra);


                if (i.ModificarItem(IdAux, nombre, descripcion, PrecioAux, CantidadAux) == true)
                {
                    MessageBox.Show("La modificacion se realizo con exito");
                }
                else
                {
                    MessageBox.Show("La modificacion no se pudo realizar");
                }
                DataSet DS = new DataSet();
                i = new ItemMenu();
                DS = i.MostrarItem();
                dataGridView1.DataSource = DS.Tables[0];


            }
            else
            {
                MessageBox.Show("Seleccione la fila modificar");
            }

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0) 
            {
                string Id;
                int IdAux;
                Id = dataGridView1.CurrentRow.Cells["codItem"].Value.ToString();
                IdAux = int.Parse(Id);
                ItemMenu i = new ItemMenu();
                if (i.EliminarItem(IdAux) == true)
                {
                    MessageBox.Show("La modificacion se realizo con exito");
                }
                else
                {
                    MessageBox.Show("La modificacion no se pudo realizar");
                }
                DataSet DS = new DataSet();
                i = new ItemMenu();
                DS = i.MostrarItem();
                dataGridView1.DataSource = DS.Tables[0];


            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar");
            }

        }
    }
}
