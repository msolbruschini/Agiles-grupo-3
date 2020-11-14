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
                MessageBox.Show("No se puede realizar esta consulta/modificacion");
            }
            finally
            {
                miConexion.Close();
            }
            return DS;

        }





        //Vuelve vacío
        public bool Ejecutor(string query)
        {
            DataSet DS = new DataSet();
            try
            {
                //SQLiteCommand myCommand = new SQLiteCommand(query, miConexion);
                miConexion.Open();
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(query, miConexion);
                sqlda.Fill(DS);
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                miConexion.Close();
            }
            

        }

        protected SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(miConexion);
        }


        public string ValorUnico(string consulta)
        {
            string precio = "0";
            using (miConexion)
            {
                SQLiteCommand cmd = new SQLiteCommand(consulta, miConexion);
                try
                {
                    miConexion.Open();
                    precio = (string)cmd.ExecuteScalar().ToString();
                }
                catch(Exception e)
                {
                    MessageBox.Show("" + e);
                }
                finally
                {
                    
                }
            }

            return precio;
        }
    }
}
