using CapaNegocio2;
using System;
using System.Collections;
using System.Data;
using System.Linq;
//using System.Windows;
using System.Windows.Forms;


namespace Interfez
{
    public partial class Form1 : Form
    {
        string texto = "Cerveza";
        int cantidad = 7;
        bool valido = true;
        DataTable pedido = new DataTable();
        
        
        
        public Form1()
        {
            InitializeComponent();
            pedido.Columns.Add("Producto");
            pedido.Columns.Add("Cantidad");
            pedido.Columns.Add("Precio");

        }



        /*private void BotonCrearPedido_Click(object sender, EventArgs e)
        {
            
            if (label1.Text == "Nuevo texto")
            {
                label1.Text = "otro texto";
            }
            else
            {
                label1.Text = "Nuevo texto";
            }



            //int numero = Int32.Parse( textoNombre.Text );

            ClasedePrueba cdp = new ClasedePrueba();
            Class1 claseP = new Class1();

            label2.Text = cdp.Calcular(numero).ToString();
            label3.Text = claseP.Calculadora(numero).ToString();



        }*/
        //BOTONES
        //Agrega un producto al mismo pedido
        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            pedido.Rows.Add(textoProducto.Text, textoCantidad.Text, textoPrecio.Text);
            listBox1.Items.Add(textoCantidad.Text + "  " + textoProducto.Text + "  " + textoPrecio.Text);
            textoPrecio.Text = "";
            textoCantidad.Text = "";
            textoProducto.Text = "";




            //MessageBox.Show("Producto: " + pedido.Rows[0]["Producto"].ToString());
        }

        //Cierra el pedido
        private void CrearPedido_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("¡Pedido Creado!");
            string nombre = textoNombre.Text;
            string direccion;
            if (checkBox2.Checked)
            {
                direccion = textDireccion.Text;
            }
            else
            {
                direccion = "Retira en persona";
            }
            string estado = comboEstado.Text;
            string pagado = "no";
            if (checkBox1.Checked)
            {
                pagado = "si";
            }
            int productosContador = pedido.Rows.Count;

            string productosTexto = " ";
            int productosPrecioFinal = 0;
            for (int i = 0; i < productosContador; i++)
            {

                string cant = pedido.Rows[i]["Cantidad"].ToString();
                string precio = pedido.Rows[i]["Precio"].ToString();
                productosPrecioFinal = productosPrecioFinal + (Int32.Parse(precio) * Int32.Parse(cant));


                productosTexto = String.Concat(pedido.Rows[i]["Producto"].ToString() + " ");




                //MessageBox.Show(productosTexto);

            }
            MessageBox.Show(productosTexto);

            MessageBox.Show("PEDIDO CREADO \n"
                + "Nombre: "
                + nombre
                + "\n"
                + "Entrega: "
                + direccion
                + "\n"
                + "Pagado: "
                + pagado
                + "\n"
                + "Estado: "
                + estado
                + "\n"
                //+ "PEDIDOS: \n"
                //+ listBox1.Text.ToString()
                + "TOTAL: "
                + productosPrecioFinal

                );



        }








        //Otras funcionalidades
        private void Form1_Load(object sender, EventArgs e)
        {
            /*groupBox1.Width = (int)(this.Width * 0.6);
            //groupBox1.Width = 30;*/
            textDireccion.Enabled = false;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            /*groupBox1.Width = (int)(this.Width * 0.6);
            //groupBox1.Width = 30;
            //panel1.Width= (int)(groupBox1.Width * 0.3);
            panel2.Width = (int)(groupBox1.Width * 0.3);
            panel3.Width = (int)(groupBox1.Width * 0.3);
            panel4.Width = (int)(groupBox1.Width * 0.3);

            Console.WriteLine("Form: " + this.Size.Width);
            Console.WriteLine("box: " + groupBox1.Size.Width);*/
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                textDireccion.Enabled = true;
            }
            else
            {
                textDireccion.Enabled = false;
            }
        }

        
    }
    }
