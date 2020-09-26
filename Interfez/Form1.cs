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
    public partial class Form1 : Form
    {
        string texto = "Cerveza";
        int cantidad = 7;
        bool valido = true;

        





        public Form1()
        {
            InitializeComponent();
        }



        private void BotonCrearPedido_Click(object sender, EventArgs e)
        {
            
            if (label1.Text == "Nuevo texto")
            {
                label1.Text = "otro texto";
            }
            else
            {
                label1.Text = "Nuevo texto";
            }



            int numero = Int32.Parse( textBox1.Text );

            ClasedePrueba cdp = new ClasedePrueba();
            Class1 claseP = new Class1();

            label2.Text = cdp.Calcular(numero).ToString();
            label3.Text = claseP.Calculadora(numero).ToString();



        }



        







    }
}
