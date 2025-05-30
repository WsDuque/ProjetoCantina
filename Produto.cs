using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    internal class Produto
    {
        private string nome;
        private double valor;
        private int quantidade;
        private bool isChapa;

        public Produto(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = 1;
            this.isChapa = false;  
        }
        public Produto(string nome, double valor, bool IsChapa)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = 1;
            this.isChapa = IsChapa;
        }
        public Produto()
        {
            this.nome = "";
            this.valor = 0;
            this.quantidade = 1;
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public double Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }

        public int Quantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }
        public string pedido
        {
            get { return $"{nome} - R${valor:n2} x{quantidade}"; }
        }
        public string cardápio
        {
            get { return $"{nome} - R${valor:n2}"; }
        }

        public override string ToString()
        {
            return $"{nome} - R${valor:n2} x {quantidade}";
        }
        public string balcão
        {
            get { return $"{nome} x{quantidade}"; }
        }
        public bool IsChapa
        {
            get { return isChapa;  }
        }
    }
}
