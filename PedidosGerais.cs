using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cantina
{
    internal class PedidosGerais
    {
        private static List<Pedido> pedidos = new List<Pedido>();
        private static int numeroPedido = 0;
        public static string fileName = "CatinaPedidos.json";
        public static string jsonString = JsonSerializer.Serialize((List<Pedido>)pedidos);

        public static List<Pedido> Pedidos
            {
                get { return pedidos;}
            }
        public static void Adicionar(Pedido pedido)
        {
            numeroPedido++;
            pedido.códigoPedido = numeroPedido;
            pedidos.Add(pedido);
        }
    }
}
