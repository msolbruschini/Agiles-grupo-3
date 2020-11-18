using CapaNegocio2;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Windows;
using System.Windows.Forms;
using CapaNegocio2;



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
            if (ValidarProducto(textoProducto.Text, textoCantidad.Text, textoPrecio.Text))
            {
                pedido.Rows.Add(textoProducto.Text, textoCantidad.Text, textoPrecio.Text);
                Items.Items.Add(textoCantidad.Text + "  " + textoProducto.Text + "  " + textoPrecio.Text);
                textoPrecio.Text = "";
                textoCantidad.Text = "";
                textoProducto.Text = "";
            }
            




            //MessageBox.Show("Producto: " + pedido.Rows[0]["Producto"].ToString());
        }

        //Cierra el pedido
        private void CrearPedido_Click(object sender, EventArgs e)
        {
            
            string nombre = textoNombre.Text;
            string direccion;
            int codPedido;
            
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

            if (ValidarPedido(nombre, direccion, estado))
            {
                //Cuenta la cantidad de productos sumados al pedido para recorrer la lista de productos
                int productosContador = pedido.Rows.Count;
                //Toma un producto y lo pone en un texto (después de mostrará por pantalla)
                string productosTexto = " ";
                //Cuenta todo para el precio final
                int productosPrecioFinal = 0;

                for (int i = 0; i < productosContador; i++)
                {
                    string cant = pedido.Rows[i]["Cantidad"].ToString();
                    string precio = pedido.Rows[i]["Precio"].ToString();
                    productosPrecioFinal = productosPrecioFinal + (Int32.Parse(precio) * Int32.Parse(cant));


                    productosTexto = String.Concat(pedido.Rows[i]["Producto"].ToString() + " ");
                }


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
                // Agrego los datos del pedido a la facturaciòn
                Factura f = new Factura();
                DateTime fecha = DateTime.Today;

                //agrego un int cualquiera al codigo pedido 
                codPedido = productosPrecioFinal + 1000;

                if (f.AgregarFactura(codPedido, productosPrecioFinal, fecha) == true)
                {
                    MessageBox.Show("Factura creada con exito");
                }
                else
                {
                    MessageBox.Show("Error al generar la factura");
                }



            }

        }




        //VALIDADORES
        //Valida los campos antes de crear pedido
        public bool ValidarPedido (string nombre, string direccion, string estado)
        {
            bool exito = true;
            if (nombre == "")
            {
                MessageBox.Show("Completá el nombre");
                exito = false;
            }
            else if ( (checkBox2.Checked) && (direccion == "") )
            {
                MessageBox.Show("Completá la dirección o desmarcá la casilla de 'entrega'");
                exito = false;
            }
            else if(estado == "")
            {
                MessageBox.Show("Completá el estado del producto");
                exito = false;
            }
            return exito;
        }

        //Valida los campos antes de crear un producto
        public bool ValidarProducto (string producto, string cantidad, string precio)
        {
            bool exito = true;
            if(producto == "")
            {
                MessageBox.Show("Completá el producto");
                exito = false;
            }
            else if (Int32.TryParse(cantidad, out int cant) == false)
            {
                MessageBox.Show("Agregá la cantidad");
                exito = false;
            }
            else if (Int32.TryParse(precio, out int prec) == false)
            {
                MessageBox.Show("Agregá el precio");
                exito = false;
            }
            return exito;
        }








        //Otras funcionalidades
        private void Form1_Load(object sender, EventArgs e)
        {
            /*groupBox1.Width = (int)(this.Width * 0.6);
            //groupBox1.Width = 30;*/
            textDireccion.Enabled = false;
            ControlExtension.Draggable(panel3, true);
            ControlExtension.Draggable(panel10, true);
            ControlExtension.Draggable(panel11, true);
            ControlExtension.Draggable(panel4, true);
            ControlExtension.Draggable(panel5, true);
            ControlExtension.Draggable(panel6, true);
            ControlExtension.Draggable(panel7, true);
            ControlExtension.Draggable(panel8, true);
            ControlExtension.Draggable(panel2, true);
            ControlExtension.Draggable(panel3, true);
            ControlExtension.Draggable(panel4, true);
            ControlExtension.Draggable(panel5, true);
            ControlExtension.Draggable(panel12, true);


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

        

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            bool tx = true;
            Inicio ini = new Inicio(tx);
            this.Hide();
            ini.ShowDialog();
        }

























        ////////////////////////////////////////////////////////////////////
        ///MESAS
        ////////////////////////////////////////////////////////////////////




    }
    }
