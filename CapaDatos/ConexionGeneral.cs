using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data;

namespace CapaDatos
{
    public class ConexionGeneral
    {
        SQLiteConnection miConexion = new SQLiteConnection("Data Source = database.sqlite3");
        public void DBCreator()
        {
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
            }
            

        }

        //Devuelve un dataset para mostrar datos...
        public DataSet Consultor(string query)
        {
            DataSet DS = new DataSet();
            try
            {
                //SQLiteCommand myCommand = new SQLiteCommand(query, miConexion);
                miConexion.Open();
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(query, miConexion);
                
                sqlda.Fill(DS);
                

            }
            catch
            {
                MessageBox.Show("Hubo un problemingui...");
            }
            finally
            {
                miConexion.Close();
            }
            return DS;

        }





        //Vuelve vacío
        public void Ejecutor(string query)
        {
            
            try
            {
                //SQLiteCommand myCommand = new SQLiteCommand(query, miConexion);
                miConexion.Open();
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(query, miConexion);

                


            }
            catch
            {
                MessageBox.Show("Hubo un problemingui...");
            }
            finally
            {
                miConexion.Close();
            }
            

        }

    }
}
