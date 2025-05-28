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
        public Balcão()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Balcão_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PedidosGerais.Pedidos)
            {
               foreach(Produto produto in pedido.Produtos)
                {
                    if (!produto.IsChapa)
                        listBox1.Items.Add(pedido);
                }
                    
            }
        }

        private void btnIrVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new();
            Hide();
            vendas.Show();
        }
    }
}
