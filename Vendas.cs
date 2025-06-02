namespace Cantina
{
    public partial class Vendas : Form
    {

        public Vendas()
        {
            InitializeComponent();
        }
        string método;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = $"Total: R$0";
            listPedido.DisplayMember = "pedido";
            listCardápio.DisplayMember = "cardápio";
            List<Produto> lista = new List<Produto>();
            lista.Add(new Produto("Pão de Queijo", 3.50));
            lista.Add(new Produto("Coxinha", 5));
            lista.Add(new Produto("Pastel de Carne", 6, true));
            lista.Add(new Produto("Pastel de Queijo", 5.50, true));
            lista.Add(new Produto("Suco Natural (300mL)", 4));
            lista.Add(new Produto("Refrigerante Lata", 4.50));
            lista.Add(new Produto("Hambúrguer Simples", 8, true));
            lista.Add(new Produto("Hambúrguer com Queijo", 9, true));
            lista.Add(new Produto("X-Tudo", 12, true));
            lista.Add(new Produto("Água Mineral (500mL)", 2.50));

            foreach (Produto produto in lista)
                listCardápio.Items.Add(produto);


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int qtd;
            if (listCardápio.SelectedItem != null)
            {
                if (!listPedido.Items.Contains(listCardápio.SelectedItem))
                {
                    if (int.TryParse(txtQuantidade.Text, out qtd))
                    {
                        Produto produto = new();
                        produto = (Produto)listCardápio.SelectedItem;
                        produto.Quantidade = qtd;
                        listPedido.Items.Add(produto);
                        listCardápio.ClearSelected();
                        txtQuantidade.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Digite um quantidade válida!");
                        txtQuantidade.Clear();
                        txtQuantidade.Focus();
                    }
                }
                else
                {
                    Produto item = new Produto();
                    if (int.TryParse(txtQuantidade.Text, out qtd))
                    {
                        foreach (Produto produto in listPedido.Items)
                        {
                            if (produto == listCardápio.SelectedItem)
                            {
                                item = (Produto)listCardápio.SelectedItem;
                                item.Quantidade += qtd;
                                txtQuantidade.Clear();
                            }


                        }
                        listPedido.Items.Remove(listCardápio.SelectedItem);
                        listPedido.Items.Add(item);
                        listCardápio.ClearSelected();
                    }
                    else
                    {
                        MessageBox.Show("Digite um quantidade válida!");
                        txtQuantidade.Clear();
                        txtQuantidade.Focus();
                    }


                }
            }
            else
                MessageBox.Show("Selecione um item!");
            totalMudando();
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listPedido.SelectedItem != null)
            {
                Produto produto = new Produto();
                produto = (Produto)listPedido.SelectedItem;
                if (produto.Quantidade == 1)
                {
                    listPedido.Items.Remove(listPedido.SelectedItem);
                    listPedido.ClearSelected();
                }
                else
                {
                    if (String.IsNullOrEmpty(txtQuantidade.Text))
                    {
                        MessageBox.Show("Digite um quantidade válida!");
                        txtQuantidade.Clear();
                        txtQuantidade.Focus();
                    }
                    else
                    {
                        int qtd = 1;
                        if (int.TryParse(txtQuantidade.Text, out qtd))
                            if (qtd < produto.Quantidade)
                            {
                                produto.Quantidade -= qtd;
                                txtQuantidade.Clear();
                                listPedido.Items.Remove(listPedido.SelectedItem);
                                listPedido.Items.Add(produto);
                                listPedido.ClearSelected();
                            }
                            else if (qtd >= produto.Quantidade)
                            {
                                listPedido.Items.Remove(listPedido.SelectedItem);
                                txtQuantidade.Clear();

                            }
                    }

                }

            }
            else
                MessageBox.Show("Selecione um item!");

            totalMudando();
        }

        public double totalMudando()
        {
            double total = 0;
            foreach (Produto produto in listPedido.Items)
            {
                total += produto.Valor * produto.Quantidade;
                lblTotal.Text = $"Total: R${total:n2}";
            }
            if (listPedido.Items.Count == 0)
            {
                total = 0;
                lblTotal.Text = $"Total: R${total:n2}";
            }
            return total;
        }

        private void listCardápio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantidade.Focus();
        }

        private void listPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantidade.Focus();
        }

        private void rbtnDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                lblDinheiro.Visible = true;
            }
            else
            {
                txtDinheiro.Visible = false;
                lblDinheiro.Visible = false;
            }
        }

        private void rbtnDébito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDébito.Checked)
            {
                método = "Débito";
            }

        }

        private void rbtnCrédito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCrédito.Checked)
            {
                método = "Crédito";
            }
        }

        private void rbtnPix_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPix.Checked)
            {
                método = "Pix";
            }
        }


        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double valor;
                double total = totalMudando();
                if (double.TryParse(txtDinheiro.Text, out valor))
                {
                    if (valor > total)
                    {
                        lblTroco.Text = $"Troco: R${valor - total}";
                        lblTroco.Visible = true;
                        método = "Dinheiro";
                    }
                    else if (valor == total)
                    {
                        método = "Dinheiro";
                        lblTroco.Visible = false;
                    }

                    else if (valor < total)
                    {
                        MessageBox.Show("Valor Insuficiente!");
                        lblTroco.Visible = false;
                    }

                }
                else
                    MessageBox.Show("Valor Inválido!");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCliente.Text) && listPedido.Items.Count != 0)
            {
                if (string.IsNullOrEmpty(método))
                {
                    MessageBox.Show("Pague o valor!");
                    return;
                }
                Pedido pedido = new Pedido();
                List<Produto> produtosPedido = new List<Produto>();
                foreach (Produto produto in listPedido.Items)
                    pedido.addProdutos(produto);
                produtosPedido = pedido.Produtos;
                pedido.Cliente = txtCliente.Text;
                pedido.IsViagem = checkViagem.Checked;
                string eViagem;
                if (checkViagem.Checked)
                {
                    eViagem = "Sim";
                }
                else
                {
                    eViagem = "Não";
                }
                string produtos = string.Join("\n", produtosPedido.Select(x => x.ToString()));
                pedido.DataTime = dateTimePicker1.Text + dateTimePicker2.Text;
                MessageBox.Show($"{pedido.Cliente}\n{produtos}\n\nMétodo de Pgmnt: {método}\nÉ viagem? {eViagem}\n\n{pedido.DataTime}");
                if (pedido.Produtos.Where(x => x.IsChapa).Any())
                    pedido.status = Pedido.Status.Preparando;
                else
                    pedido.status = Pedido.Status.Pronto;
                PedidosGerais.Adicionar(pedido);
                listPedido.Items.Clear();
                txtCliente.Clear();
                rbtnCrédito.Checked = false;
                rbtnDébito.Checked = false;
                rbtnPix.Checked = false;
                rbtnDinheiro.Checked = false;
                lblTroco.Visible = false;
                checkViagem.Checked = false;
                totalMudando();
            }
            else
            {
                btnFinalizar.Cursor = Cursors.No;
            }
        }

        private void listCardápio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listCardápio.ClearSelected();
                txtQuantidade.Focus();
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && listCardápio.SelectedItem != null)
            {
                btnAdicionar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnRemover_Click(sender, e);

            }

        }

        private void btnIrBalcão_Click(object sender, EventArgs e)
        {
            Balcão balcão = new Balcão();
            Hide();
            balcão.Show();
        }

        private void lblTroco_Click(object sender, EventArgs e)
        {

        }
    }
}
