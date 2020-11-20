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


        public bool AgregarItem(string nombre, string descripcion, float precio, int cantidad)
        {
           
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO ItemStock ( nombre,descripcion,cantidad,precio ) VALUES ( '" + nombre + "', '" + descripcion + "','" + cantidad + "','" + precio + "')");
            
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


        public bool EliminarItem(int codItem)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("DELETE from ItemStock where codItem = " + codItem);


        }

    }
}
