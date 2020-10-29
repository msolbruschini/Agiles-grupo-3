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
    public class Usuario : ConexionGeneral 
    {
        public bool Login(string cuenta, string contra)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand())
                {
                    command.Connection = connection;
                    //trabajando con parametros en sql
                    command.Parameters.AddWithValue("@user", cuenta);
                    command.Parameters.AddWithValue("@pass", contra);
                    command.CommandText = "Select * FROM Usuario WHERE NomUsuario=@user AND PassUsuario = @pass";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

    }
}
