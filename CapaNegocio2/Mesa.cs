using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio2
{
    public class Mesa
    {   
        public bool MesaEstado(int mesa)
        {
            bool MesaEst = false; 
            ConexionGeneral CG = new ConexionGeneral();
            string mesaTexto;
            mesaTexto = CG.ValorUnico("SELECT estadoMesa FROM Mesa WHERE idMesa = " + mesa + "");
            if(mesaTexto == "1")
            {
                MesaEst = true;
            }
            return MesaEst;
        }
    }
}
