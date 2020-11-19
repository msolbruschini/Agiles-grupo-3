using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio2
{
    public class ItemMenu
    {
        public DataSet MostrarItem()
        {
           
            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT * FROM ItemStock");
            return DS;
        }


        public bool AgregarItem(string producto, string codigo,string categoria, string descripcion, string comentario, float precioCompra, int cantidad)
        {
           
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO ItemStock ( nombre,descripcion,cantidad,precio ) VALUES ( '" + producto + "', '" + codigo + "','" + categoria + "','" + descripcion + "', '" + comentario + "'," + precioCompra + "," + cantidad + ")");
            
        }

        public DataSet MostrarItemBuscado(string nombreBuscado)
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT * FROM ItemStock where nombre like '%" + nombreBuscado + "%'");
            return DS;
        }

        public bool ModificarItem(int codItem , string nombre , string descripcion , float precio , int cantidad)
        {
            ConexionGeneral CG = new ConexionGeneral();
            
            return CG.Ejecutor("UPDATE ItemStock SET nombre = '" + nombre + "',descripcion = '" + descripcion + "', precio = " + precio + " ,cantidad = " + cantidad + " where codItem = " + codItem);


        }

    }
}
