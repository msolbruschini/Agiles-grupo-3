using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio2
{
    public class Pedido
    {   
        public int CrearPedido(int mesa)
        {
            ConexionGeneral CG = new ConexionGeneral();
            CG.Ejecutor("INSERT INTO Pedido (idCliente, tipo, mesa, idEmpleado) VALUES (0, 0," + mesa + ", 0)");
            string pedidoString = CG.ValorUnico("SELECT idPedido FROM Pedido ORDER BY idPedido DESC LIMIT 1 ");
            int pedidoNum = int.Parse(pedidoString);
            return pedidoNum;

        }




    }
}
