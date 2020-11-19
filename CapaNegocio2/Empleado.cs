using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio2
{
    public class Empleado
    {
        public DataSet MostrarEmpleado()
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT idEmpleado,dni,nombre,direccion FROM Empleado");
            return DS;
        }


        public bool NuevoEmpleado(int dni, string nombre, string direccion)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Empleado ( dni, nombre, direccion) VALUES ( " + dni + ", '" + nombre + "','" + direccion + "')");

        }

        public DataSet MostrarEmpleadoBuscado(string nombreBuscado)
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT idEmpleado,dni,nombre,direccion FROM Empleado where nombre like '%" + nombreBuscado + "%'");
            return DS;
        }

        public bool ModificarEmpleado(int idEmpleado, int dni, string nombre, string direccion)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("UPDATE Empleado SET dni = " + dni + ",nombre = '" + nombre + "',direccion = '" + direccion + "' where idEmpleado = " + idEmpleado);


        }
        

        

    }
}
