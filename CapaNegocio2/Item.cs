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
            DS = CG.Consultor("SELECT StockId,codigo,producto,categoria,precioCompra,cantidad FROM Stock");
            return DS;
        }


        /*public DataSet AgregarItem(string nombre, int cantidad)
        {
            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            
            DS = CG.Consultor("INSERT INTO Item (ItemNombre, ItemCant) VALUES (" + nombre + ", " + cantidad + "");
            return DS;
        }*/

        public DataSet MostrarItemBuscado(string nombreBuscado)
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT StockId,codigo,producto,categoria,precioCompra,cantidad FROM Stock where producto like '%" + nombreBuscado + "%'");
            return DS;
        }

        public String ModificarItem(int StockId , string codigo , string producto , string categoria , float precioCompra , int cantidad)
        {
            ConexionGeneral CG = new ConexionGeneral();
            CG.Consultor("UPDATE Stock SET codigo = '" + codigo + "',producto = '" + producto + "',categoria = '" + categoria + "', precioCompra = " + precioCompra + " ,cantidad = " + cantidad + " where StockId = " + StockId);
            return null;
            
            
        }

    }
}
