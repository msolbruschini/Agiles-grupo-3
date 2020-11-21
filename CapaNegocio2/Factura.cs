﻿using System;
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
        public bool AgregarFactura(int codPedido, int totalFact, string fecha)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Factura ( codPedido, totalFact, fecha) VALUES (" + codPedido + "," + totalFact + ", '" + fecha + "')");

        }
        public DataSet MostrarFactura()
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT * FROM Factura");
            return DS;
        }
        public DataSet MostrarFacturaDesde(DateTime fechaDesde)
        {

            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            string fecha = fechaDesde.ToString();
            DS = CG.Consultor("SELECT idFactura,codPedido, totalFact, fecha FROM Factura AS f WHERE (f.fecha >= '" + fecha + "') AND (f.totalFact > 0)");
            return DS;
        }
    }
}
