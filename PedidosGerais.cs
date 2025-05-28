using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    internal class PedidosGerais
    {
        private static List<Pedido> pedidos = new List<Pedido>();

        public static List<Pedido> Pedidos
            {
                get { return pedidos;}
            }
        public static void Adicionar(Pedido pedido)
        {
            pedidos.Add(pedido);
        }
    }
}
