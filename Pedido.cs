using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    internal class Pedido
    {
        private string cliente;
        private int código;
        private List<Produto> produtos = new();
        private bool isViagem;
        private string status;
        private string dataHora;
        public string pedidoBalcão;
       
        //private int código;
        public string Cliente
         {
            get { return cliente; }
            set { cliente = value; }    
         }
        public List<Produto> Produtos
        {
            get { return produtos; }
        }

        public void addProdutos(Produto produto) 
        {
            produtos.Add(produto); 
        }
        public string PedidoBalcão
        {
            get { return pedidoBalcão; }
        }
        public bool IsViagem
        {
            get { return isViagem; }
            set { this.isViagem = value; }
        }
        public string DataTime
        {
            get { return dataHora; }
            set { dataHora = value; }
        }

    }
}
