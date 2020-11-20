using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaNegocio2
{
    public class Factura
    {
        public bool AgregarFactura(int codPedido, float totalFact, DateTime fecha)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Factura ( codPedido, totalFact, fecha) VALUES (" + codPedido + "," + totalFact + ", '" + fecha + "')");

        }
        public DataSet MostrarFactura()
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT codPedido, totalFact, fecha FROM Factura");
            return DS;
        }
        public DataSet MostrarFacturaDesde(string fechaDesde)
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT codPedido, totalFact, fecha FROM Factura WHERE f.fecha >= '" + fechaDesde + "'");
            return DS;
        }
    }
}
