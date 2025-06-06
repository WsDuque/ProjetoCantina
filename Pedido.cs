using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Status status;
        private bool temChapa = false;
        private string dataHora;
        public enum Status
        {
            Preparando,
            Pronto,
            Entregue
        }
        public string PedidoStatus
        {
            get {  return $"{código} - {cliente} - {status} - {dataHora}"; }
        }
        public override string ToString()
        {
            return $"{código} - {cliente}";
        }
        public int códigoPedido
        {
            get { return código; }
            set {código = value; }
        }
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
            if (produto.IsChapa)
            {
                this.temChapa = true;
            }
            produtos.Add(produto); 
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
        public bool TemChapa
        {
            get { return temChapa; }
            set { temChapa = value; }
        }
    }
}
