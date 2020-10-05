using CapaNegocio2;
using System;
//using System.Windows;
using System.Windows.Forms;


namespace Interfez
{
    public partial class Form1 : Form
    {
        string texto = "Cerveza";
        int cantidad = 7;
        bool valido = true;

        





        public Form1()
        {
            InitializeComponent();
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

         private void Form1_Load(object sender, EventArgs e)
        {
            /*groupBox1.Width = (int)(this.Width * 0.6);
            //groupBox1.Width = 30;*/
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CrearPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Pedido Creado!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
