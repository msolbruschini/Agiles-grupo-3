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
            DS = CG.Consultor("SELECT idEmpleado,dni,nombre,direccion,horas,Xhs,sueldo FROM Empleado");
            return DS;
        }


        public bool NuevoEmpleado(int dni, string nombre, string direccion, int horas, int vHs, int sueldo)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Empleado ( dni, nombre, direccion, horas, Xhs, sueldo) VALUES ( " + dni + ", '" + nombre + "','" + direccion + "', " + horas + ", " + vHs + ", " + sueldo + ")");

        }

        public DataSet MostrarEmpleadoBuscado(string nombreBuscado)
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT idEmpleado,dni,nombre,direccion,horas,Xhs,sueldo FROM Empleado where nombre like '%" + nombreBuscado + "%'");
            return DS;
        }

        public bool ModificarEmpleado(int idEmpleado, int dni, string nombre, string direccion, int horas, int vHs, int sueldo)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("UPDATE Empleado SET dni = " + dni + ",nombre = '" + nombre + "',direccion = '" + direccion + "', horas = " + horas + ", Xhs = " + vHs + ",sueldo = " + sueldo + "  where idEmpleado = " + idEmpleado);


        }

        public bool EliminarEmpleado(int idEmpleado)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("DELETE from Empleado where idEmpleado = " + idEmpleado);


        }




    }
}
