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
        
        public bool IsViagem
        {
            get { return isViagem; }
            set { this.isViagem = value; }
        }
    }
}
