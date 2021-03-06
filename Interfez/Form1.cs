﻿using CapaNegocio2;
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
        int mesaSeleccionada = 0;
        Panel p = null;
        
        
        
        public Form1()
        {
            InitializeComponent();
            pedido.Columns.Add("Producto");
            pedido.Columns.Add("Cantidad");
            pedido.Columns.Add("Precio");
            labelMesaVacia.Visible = false;

        }



        
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
                string fechaParametro = fecha.ToString();

                //agrego un int cualquiera al codigo pedido 
                int codPedido = productosPrecioFinal + 1000;

                if (f.AgregarFactura(codPedido, productosPrecioFinal, fechaParametro) == true)
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
            
            //Hago a todos los elementos arrastrables
            /*groupBox1.Width = (int)(this.Width * 0.6);
            //groupBox1.Width = 30;*/
            textDireccion.Enabled = false;
            ControlExtension.Draggable(p8, true);
            ControlExtension.Draggable(p9, true);
            ControlExtension.Draggable(p10, true);
            ControlExtension.Draggable(p11, true);
            ControlExtension.Draggable(p12, true);
            ControlExtension.Draggable(p13, true);
            ControlExtension.Draggable(p5, true);
            ControlExtension.Draggable(p6, true);
            ControlExtension.Draggable(p7, true);
            ControlExtension.Draggable(p8, true);
            ControlExtension.Draggable(p11, true);
            ControlExtension.Draggable(p12, true);
            ControlExtension.Draggable(p1, true);
            //Cargo la tabla de productos en la pestaña mesas
            Item i = new Item();
            DataTable dt = i.MostrarNombres();
            int cantItem = dt.Rows.Count;
            for (int cont = 0; cont<cantItem; cont++)
            {
                comboBoxItem.Items.Add(dt.Rows[cont]["nombre"].ToString());
            }

                


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

        private void textoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(textoProducto.SelectedIndex != -1)
            {
                Item i = new Item();
                textoPrecio.Text = i.MostrarPrecio(textoProducto.Text).ToString();
            }
        }




























        ////////////////////////////////////////////////////////////////////
        ///MESAS
        ////////////////////////////////////////////////////////////////////

        private void p1_Click(object sender, EventArgs e)
        {
            MesaX(sender);


        }




        private void MesaX(object sender)
        {
            // Cuando selecciono una mesa, des-selecciono la mesa anterior y selecciono la nueva
            labelMesaVacia.Visible = false;
            dataGridView2.DataSource = null;
            botonAbrirMesa.Enabled = true;
            botonCerrarMesa.Enabled = true;
            if (p != null)
            {
                p.BorderStyle = BorderStyle.None;
            }

            p = (Panel)sender;


            p.BorderStyle = BorderStyle.FixedSingle;
            //Chequeo si la mesa está ocupada o no(false -> vacía ; true -> ocupada)
            Mesa m = new Mesa();
            //MESA VACIA
            if (m.MesaEstado(Int32.Parse(p.Tag.ToString())) == false)
            {
                labelMesaVacia.Visible = true;
                botonCerrarMesa.Enabled = false;
                comboBoxItem.Visible = false;
                comboBoxItem.SelectedIndex = -1;
                mesaTextoPrecio.Visible = false;
                mesaTextCantidad.Text = "";
                mesaTextCantidad.Visible = false;
                mesaTextoPrecio.Text = "";
                botonMesaAgregar.Enabled = false;
            }
            //MESA LLENA
            else
            {
                MesaLlena();

            }
        }





        //Abre una mesa y permite sumar pedidos
        private void botonAbrirMesa_Click(object sender, EventArgs e)
        {
            //CREO EL PEDIDO Y LO ASOCIO A LA MESA
            Pedido ped = new Pedido();
            int pedidoNumero = ped.CrearPedido(Int32.Parse(p.Tag.ToString()));

            //PONGO LA MESA COMO OCUPADA Y LE VINCULO EL PEDIDO
            Mesa m = new Mesa();
            m.MesaOcupar(Int32.Parse(p.Tag.ToString()), pedidoNumero);

            //CARGO EL DATASET VACÍO
            MesaLlena();

        }


        //Hago cosas de interfaz cuando la mesa está llena
        public void MesaLlena()
        {
            botonAbrirMesa.Enabled = false;
            botonCerrarMesa.Enabled = true;
            DataSet DDSS = new DataSet();
            labelMesaVacia.Visible = false;

            int mesaNumero = Int32.Parse(p.Tag.ToString());
            Mesa m = new Mesa();
            DDSS = m.PedidoVer(mesaNumero);
            dataGridView2.DataSource = DDSS.Tables[0];


            comboBoxItem.Visible = true;
            mesaTextoPrecio.Visible = true;
            mesaTextCantidad.Visible = true;
            botonMesaAgregar.Enabled = true;
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItem.Text == "")
            {
                //comboBoxItem.Text = "Item";
                //comboBoxItem.ForeColor = Color.Gainsboro;
            }
            else
            {
                comboBoxItem.ForeColor = Color.Black;
            }
        }

        private void mesaTextCantidad_TextChanged(object sender, EventArgs e)
        {
            if (mesaTextCantidad.Text == "")
            {
                //mesaTextCantidad.Text = "Cantidad";
                //mesaTextCantidad.ForeColor = Color.Gainsboro;
            }
            else
            {
                mesaTextCantidad.ForeColor = Color.Black;
                if (comboBoxItem.Text != "")
                {
                    if (int.TryParse(mesaTextCantidad.Text, out int cant) == true)
                    {
                        Item i = new Item();
                        int precio = int.Parse(i.MostrarPrecio(comboBoxItem.Text)) * cant;
                        mesaTextoPrecio.Text = precio.ToString();
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((comboBoxItem.Text != "") && (mesaTextCantidad.Text != ""))
            {
                //Lógica de inserción
                Mesa mesita = new Mesa();
                int numPedido = mesita.MesaVerPedido(int.Parse(p.Tag.ToString()));
                PedidoItem pi = new PedidoItem();
                Item ite = new Item();
                int codigoItem = ite.DevolverID(comboBoxItem.Text);
                pi.PedidoItemCrear(codigoItem, int.Parse(mesaTextCantidad.Text), int.Parse(mesaTextoPrecio.Text), numPedido);

                //Vacío los campos
                comboBoxItem.SelectedIndex = -1;
                mesaTextCantidad.Text = "";
                mesaTextoPrecio.Text = "";
                MessageBox.Show("Producto agregado al pedido");

                //Relleno el dataGrid
                int mesaNumero = Int32.Parse(p.Tag.ToString());
                Mesa m = new Mesa();
                DataSet DDSS = new DataSet();
                DDSS = m.PedidoVer(mesaNumero);
                dataGridView2.DataSource = DDSS.Tables[0];
            }
            
        }

        private void botonCerrarMesa_Click(object sender, EventArgs e)
        {
            //Recorro el DataGridView y cuento el total
            int cont = dataGridView2.Rows.Count;
            int total = 0;
            for(int contador = 0; contador<cont; contador++)
            {
                total = total + int.Parse(dataGridView2.Rows[contador].Cells["precio"].Value.ToString());
                
            }

            //Muestro el panel con el resultado final
            panelMesaCerrada.Visible = true;
            panelMesaCerrada.BringToFront();
            labelMesaTotal.Text = total.ToString();
            labelMesaCerrada.Text = "Mesa " + p.Tag.ToString();
            DataSet DDSS = new DataSet();
            int mesaNumero = Int32.Parse(p.Tag.ToString());
            Mesa m = new Mesa();
            DDSS = m.PedidoVer(mesaNumero);
            dataGridView3.DataSource = DDSS.Tables[0];

            //Vacío la mesa
            
            m.MesaVaciar(int.Parse(p.Tag.ToString()));
            botonMesaAgregar.Enabled = false;
            botonCerrarMesa.Enabled = false;
            botonAbrirMesa.Enabled = true;
            dataGridView2.DataSource = null;



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelMesaCerrada.Visible = false;
        }
    }
}
