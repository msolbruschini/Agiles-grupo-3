using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio2
{
    public class Item
    {
        public DataSet MostrarItem()
        {
           
            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT * FROM Item I LEFT JOIN Cerveza C ON C.codItem = I.codItem");
            return DS;
        }


        /*public DataSet AgregarItem(string nombre, int cantidad)
        {
            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            
            DS = CG.Consultor("INSERT INTO Item (ItemNombre, ItemCant) VALUES (" + nombre + ", " + cantidad + "");
            return DS;
        }*/
    }
}
