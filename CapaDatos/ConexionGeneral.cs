using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;


namespace CapaDatos
{
    public class ConexionGeneral
    {
       //SQLiteConnection miConexion = new SQLiteConnection("Data Source = database.sqlite3" );
       
        public void DBCreator()
        {
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
            }
            
        }
        
    }
}
