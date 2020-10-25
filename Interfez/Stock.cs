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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                if (!textBox1.Text.Trim().Equals(""))
                {
                    DataSet DS = new DataSet();
                    Item i = new Item();
                    DS = i.MostrarItemBuscado(textBox1.Text.Trim());
                    try
                    {
                        dataGridView1.DataSource = DS.Tables[0];
                    }
                    finally {
                    
                    }
                }

            }
        }
}
