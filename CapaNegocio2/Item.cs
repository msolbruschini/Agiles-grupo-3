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


        public bool AgregarItem(string producto, string codigo,string categoria, string descripcion, string comentario, float precioCompra, int cantidad)
        {
           
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Stock ( producto, codigo, categoria, descripcion, comentario, precioCompra, cantidad) VALUES ( '" + producto + "', '" + codigo + "','" + categoria + "','" + descripcion + "', '" + comentario + "'," + precioCompra + "," + cantidad + ")");
            
        }

        public DataSet MostrarItemBuscado(string nombreBuscado)
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT StockId,codigo,producto,categoria,precioCompra,cantidad FROM Stock where producto like '%" + nombreBuscado + "%'");
            return DS;
        }

        public bool ModificarItem(int StockId , string codigo , string producto , string categoria , float precioCompra , int cantidad)
        {
            ConexionGeneral CG = new ConexionGeneral();
            
            return CG.Ejecutor("UPDATE Stock SET codigo = '" + codigo + "',producto = '" + producto + "',categoria = '" + categoria + "', precioCompra = " + precioCompra + " ,cantidad = " + cantidad + " where StockId = " + StockId);


        }
        public DataSet MostrarDetalle(int id)
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            
            DS = CG.Consultor("SELECT producto,descripcion,precioCompra FROM Stock WHERE StockID =  " + id );
            return DS;
        }

    }
}
