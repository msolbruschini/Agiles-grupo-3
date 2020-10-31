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
                        while (reader.Read())
                        {
                           DatosUsuario.usuarioId = reader.GetInt32(0);
                           DatosUsuario.usuarioNom = reader.GetString(1);                           
                           DatosUsuario.usuarioPass = reader.GetString(2);
                           DatosUsuario.usuarioEmail = reader.GetString(3);
                           DatosUsuario.usuarioTipo = reader.GetString(4);
                           
                           
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static class DatosUsuario
        {
            public static int usuarioId { get; set; }
            public static string usuarioNom { get; set; }
            public static string usuarioPass { get; set; }
            public static string usuarioTipo { get; set; }
            public static string usuarioEmail { get; set; }
        }


    }
}
