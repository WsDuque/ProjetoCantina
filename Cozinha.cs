using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PedidosGerais.Pedidos)
            {
                if (pedido.status == Pedido.Status.Preparando)
                {
                    listCozinha.Items.Add(pedido);
                }
            }
        }

        private void btnIrVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            Hide();
            vendas.ShowDialog();

        }

        private void listCozinha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCozinha.SelectedItem != null)
            {
                listDetalhesPedido.Items.Clear();
                Pedido pedido = listCozinha.SelectedItem as Pedido;
                foreach (Produto produto in pedido.Produtos)
                {
                    listDetalhesPedido.Items.Add(produto);
                }
            }

        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            if (listCozinha.SelectedItem != null)
            {
                
                foreach(Pedido pedido in PedidosGerais.Pedidos)
                {
                    if (pedido == listCozinha.SelectedItem)
                    { 
                        pedido.status = Pedido.Status.Pronto;
                    }
                }
    
                listDetalhesPedido.Items.Clear();
                listCozinha.Items.Remove(listCozinha.SelectedItem); 
            }
        }
    }
}
