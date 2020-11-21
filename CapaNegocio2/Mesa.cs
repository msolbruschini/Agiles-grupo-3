using System;
using System.Collections.Generic;
using System.Data;
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


        public DataSet PedidoVer(int numMesa)
        {
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DDSS = CG.Consultor("SELECT ItemStock.nombre, PedidoItem.cantidad, PedidoItem.precio FROM Mesa INNER JOIN Pedido ON Mesa.pedidoMesa = Pedido.idPedido INNER JOIN PedidoItem ON Pedido.idPedido = PedidoItem.idPedido INNER JOIN ItemStock ON ItemStock.codItem = PedidoItem.codItem WHERE Mesa.idMesa = " + numMesa + "");
            

            return DDSS;
        }



        public void MesaOcupar(int numMesa, int numPedido)
        {
            ConexionGeneral CG = new ConexionGeneral();
            CG.Ejecutor("UPDATE Mesa SET estadoMesa = 1, pedidoMesa = " + numPedido + " WHERE idMesa = " + numMesa + "");
        }


        public void MesaVaciar(int numMesa)
        {
            ConexionGeneral CG = new ConexionGeneral();
            CG.Ejecutor("UPDATE Mesa SET estadoMesa = 0, pedidoMesa = 0 WHERE idMesa = " + numMesa + "");
        }

        public int MesaVerPedido(int mesa)
        {
            ConexionGeneral CG = new ConexionGeneral();
            return int.Parse(CG.ValorUnico("SELECT pedidoMesa FROM Mesa WHERE idMesa = " + mesa + ""));

        }
    }
}
