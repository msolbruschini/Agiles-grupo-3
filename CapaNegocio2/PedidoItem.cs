using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio2
{
    public class PedidoItem
    {
        public void PedidoItemCrear(int Itemcod, int cantidad, int precio, int idPedido)
        {
            ConexionGeneral CG = new ConexionGeneral();
            CG.Ejecutor("INSERT INTO PedidoItem (codItem, cantidad, precio, idPedido) VALUES (" + Itemcod + ", " + cantidad + ", " + precio + "," + idPedido + ")");
        }
    }
}
