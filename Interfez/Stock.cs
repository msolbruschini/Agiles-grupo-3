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

namespace Interfez
{



    public partial class Stock : Form
    {


        public class Helper
        {
            public static DataTable DataTableFromTextFile(string location, char delimiter = ',')
            {
                DataTable result;

                string[] LineArray = File.ReadAllLines(location);

                result = FormDataTable(LineArray, delimiter);

                return result;
            }

            private static DataTable FormDataTable(string[] LineArray, char delimiter)
            {
                DataTable dt = new DataTable();

                AddColumnToTable(LineArray, delimiter, ref dt);

                AddRowToTable(LineArray, delimiter, ref dt);

                return dt;
            }

            private static void AddRowToTable(string[] valueCollection, char delimiter, ref DataTable dt)
            {

                for (int i = 1; i < valueCollection.Length; i++)
                {
                    string[] values = valueCollection[i].Split(delimiter);
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < values.Length; j++)
                    {
                        dr[j] = values[j];
                    }
                    dt.Rows.Add(dr);
                }
            }

            private static void AddColumnToTable(string[] columnCollection, char delimiter, ref DataTable dt)
            {
                string[] columns = columnCollection[0].Split(delimiter);
                foreach (string columnName in columns)
                {
                    DataColumn dc = new DataColumn(columnName, typeof(string));
                    dt.Columns.Add(dc);
                }
            }

        }

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
            dataGridView1.DataSource = Helper.DataTableFromTextFile(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Testing.txt"), '|');
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
