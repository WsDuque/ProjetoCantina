using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Estoque : Form
    {
        static List<Produto> estoqueProdutos = new List<Produto>();
        public string fileName = "CantinaProdutos.json";
        public Estoque()
        {
            InitializeComponent();
        }
        public void addEstoqueJSOn(string fileName)
        {
            string jsonString = JsonSerializer.Serialize(estoqueProdutos);
            File.WriteAllText(fileName, jsonString);
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            estoqueProdutos.Add(new Produto("Pão de Queijo", 3.50));
            estoqueProdutos.Add(new Produto("Coxinha", 5));
            estoqueProdutos.Add(new Produto("Pastel de Carne", 6, true));
            estoqueProdutos.Add(new Produto("Pastel de Queijo", 5.50, true));
            estoqueProdutos.Add(new Produto("Suco Natural (300mL)", 4));
            estoqueProdutos.Add(new Produto("Refrigerante Lata", 4.50));
            estoqueProdutos.Add(new Produto("Hambúrguer Simples", 8, true));
            estoqueProdutos.Add(new Produto("Hambúrguer com Queijo", 9, true));
            estoqueProdutos.Add(new Produto("X-Tudo", 12, true));
            estoqueProdutos.Add(new Produto("Água Mineral (500mL)", 2.50));


        }
        public void getListaJSON(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            estoqueProdutos = JsonSerializer.Deserialize<List<Produto>>(jsonString);
            foreach (Produto produto3 in estoqueProdutos)
                listEstoque.Items.Add(produto3);

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            getListaJSON(fileName);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            addEstoqueJSOn(fileName);
        }
    }
}
