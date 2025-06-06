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
    public partial class Chamada : Form
    {
        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in PedidosGerais.Pedidos)
            {
                if (pedido.status == Pedido.Status.Preparando || pedido.status == Pedido.Status.Pronto)
                {
                    listPreparando.Items.Add(pedido);
                }
                else if(pedido.status == Pedido.Status.Entregue)
                {
                    listPronto.Items.Add(pedido);
                }
            }
        }

        private void btnIrVendas_Click(object sender, EventArgs e)
        {
            Balcão balcão = new();
            Hide();
            balcão.Show();
        }

     

        private void listPreparando_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
