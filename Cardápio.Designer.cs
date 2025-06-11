namespace Cantina
{
    partial class Cardápio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listProdutos = new ListBox();
            btnSalvar = new Button();
            lblBalcão = new Label();
            pictureBox1 = new PictureBox();
            btnIrVendas = new Button();
            pictureBox6 = new PictureBox();
            txtProduto = new TextBox();
            lblProduto = new Label();
            btnAdd = new Button();
            lblPreço = new Label();
            txtPreço = new TextBox();
            IsChapa = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // listProdutos
            // 
            listProdutos.BackColor = Color.FromArgb(202, 196, 183);
            listProdutos.Font = new Font("Inter", 9.75F);
            listProdutos.FormattingEnabled = true;
            listProdutos.ItemHeight = 18;
            listProdutos.Location = new Point(58, 146);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(349, 238);
            listProdutos.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(58, 405);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 33);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblBalcão
            // 
            lblBalcão.AutoSize = true;
            lblBalcão.Font = new Font("Agrandir", 30F, FontStyle.Bold);
            lblBalcão.Location = new Point(164, 58);
            lblBalcão.Name = "lblBalcão";
            lblBalcão.Size = new Size(199, 54);
            lblBalcão.TabIndex = 48;
            lblBalcão.Text = "Cardápio";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(241, 241, 241);
            pictureBox1.Location = new Point(661, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // btnIrVendas
            // 
            btnIrVendas.Location = new Point(12, 12);
            btnIrVendas.Name = "btnIrVendas";
            btnIrVendas.Size = new Size(37, 36);
            btnIrVendas.TabIndex = 45;
            btnIrVendas.Text = "<";
            btnIrVendas.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(-3, -110);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(806, 225);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
            // 
            // txtProduto
            // 
            txtProduto.BackColor = Color.FromArgb(202, 196, 183);
            txtProduto.Location = new Point(434, 172);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(142, 23);
            txtProduto.TabIndex = 49;
            txtProduto.TextChanged += txtProduto_TextChanged;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.FromArgb(230, 255, 0);
            lblProduto.BorderStyle = BorderStyle.FixedSingle;
            lblProduto.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduto.ForeColor = Color.Black;
            lblProduto.Location = new Point(434, 146);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(77, 23);
            lblProduto.TabIndex = 50;
            lblProduto.Text = "Produto:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(230, 255, 0);
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(478, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 36);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPreço
            // 
            lblPreço.AutoSize = true;
            lblPreço.BackColor = Color.FromArgb(230, 255, 0);
            lblPreço.BorderStyle = BorderStyle.FixedSingle;
            lblPreço.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreço.ForeColor = Color.Black;
            lblPreço.Location = new Point(434, 211);
            lblPreço.Name = "lblPreço";
            lblPreço.Size = new Size(61, 23);
            lblPreço.TabIndex = 52;
            lblPreço.Text = "Preço:";
            // 
            // txtPreço
            // 
            txtPreço.BackColor = Color.FromArgb(202, 196, 183);
            txtPreço.Location = new Point(434, 237);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(142, 23);
            txtPreço.TabIndex = 53;
            // 
            // IsChapa
            // 
            IsChapa.AutoSize = true;
            IsChapa.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            IsChapa.Location = new Point(437, 289);
            IsChapa.Name = "IsChapa";
            IsChapa.Size = new Size(139, 25);
            IsChapa.TabIndex = 54;
            IsChapa.Text = "Feito na Chapa";
            IsChapa.UseVisualStyleBackColor = true;
            // 
            // Cardápio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IsChapa);
            Controls.Add(txtPreço);
            Controls.Add(lblPreço);
            Controls.Add(btnAdd);
            Controls.Add(lblProduto);
            Controls.Add(txtProduto);
            Controls.Add(listProdutos);
            Controls.Add(lblBalcão);
            Controls.Add(pictureBox1);
            Controls.Add(btnIrVendas);
            Controls.Add(btnSalvar);
            Controls.Add(pictureBox6);
            Name = "Cardápio";
            Text = "Estoque";
            Load += Estoque_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listProdutos;
        private Button btnSalvar;
        private Label lblBalcão;
        private PictureBox pictureBox1;
        private Button btnIrVendas;
        private PictureBox pictureBox6;
        private TextBox txtProduto;
        private Label lblProduto;
        private Button btnAdd;
        private Label lblPreço;
        private TextBox txtPreço;
        private CheckBox IsChapa;
    }
}