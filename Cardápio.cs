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
    public partial class Cardápio : Form
    {
        static List<Produto> produtosCardápio = new List<Produto>();
        public string fileName = "CantinaProdutos.json";
        public Cardápio()
        {
            InitializeComponent();
        }
        public void addEstoqueJSOn(string fileName)
        {
            string jsonString = JsonSerializer.Serialize(produtosCardápio);
            File.WriteAllText(fileName, jsonString);
        }
        public void getListaJSON(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            produtosCardápio = JsonSerializer.Deserialize<List<Produto>>(jsonString);
            foreach (Produto produto3 in produtosCardápio)
                listProdutos.Items.Add(produto3);
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            getListaJSON(fileName);
            listProdutos.DisplayMember = "cardápio";    
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            addEstoqueJSOn(fileName);
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double qtd;
            if (!string.IsNullOrEmpty(txtProduto.Text))
            {
                if(Double.TryParse(txtPreço.Text, out qtd))
                {
                    if (!listProdutos.Items.Contains(txtProduto.Text))
                    {
                        Produto produto = new Produto(txtProduto.Text, qtd, IsChapa.Checked);
                        listProdutos.Items.Add(produto);
                    }
                    else
                     MessageBox.Show("Produto já existente! Edite ou Remova.");
                }
                else
                 MessageBox.Show("Digite um preço válido!");
            }
            else
             MessageBox.Show("Digite o nome do Produto!");
        }
    }
}
