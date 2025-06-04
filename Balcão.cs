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
    public partial class Balcão : Form
    {
        bool históricoClicado = false;
        public Balcão()
        {
            InitializeComponent();
        }
        private void Balcão_Load(object sender, EventArgs e)
        {

            foreach (var pedido in PedidosGerais.Pedidos)
            {

                if (Pedido.Status.Pronto == pedido.status)
                {
                    listBalcão.Items.Add(pedido);
                    listHistórico.Items.Add(pedido);
                }
            }
        }
        private void btnIrVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new();
            Hide();
            vendas.Show();
        }

        private void listBalcão_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBalcão.SelectedItem != null)
            {
                listDetalhesBalcão.Items.Clear();
                listDetalhesBalcão.Visible = true;
                Pedido pedido = new();
                pedido = listBalcão.SelectedItem as Pedido;
                foreach (Produto produto in pedido.Produtos)
                    listDetalhesBalcão.Items.Add($"- {produto}");
            }
            else if (listBalcão.SelectedItem == null)
                listDetalhesBalcão.Visible = false;
        }

        private void btnHistórico_Click(object sender, EventArgs e)
        {

            if (!históricoClicado)
            {
                listDetalhesBalcão.Visible = false;
                listBalcão.Visible = false;
                listHistórico.Visible = true;
                históricoClicado = true;
            }
            else
            {
                listDetalhesHistórico.Visible = false;
                listBalcão.Visible = true;
                listHistórico.Visible = false;
                históricoClicado = false;
            }
        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            if (listBalcão.SelectedItem != null)
            {
                listBalcão.Items.Remove(listBalcão.SelectedItem);
            }
        }

        private void listHistórico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHistórico.SelectedItem != null)
            {
                listDetalhesHistórico.Items.Clear();
                listDetalhesHistórico.Visible = true;
                Pedido pedido = new();
                pedido = listHistórico.SelectedItem as Pedido;
                foreach (Produto produto in pedido.Produtos)
                    listDetalhesHistórico.Items.Add($"- {produto}");
            }
            else
                listDetalhesHistórico.Visible=false;
        }
    }
}
