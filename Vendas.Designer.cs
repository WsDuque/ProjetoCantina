namespace Cantina
{
    partial class Vendas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            btnAdicionar = new Button();
            btnRemover = new Button();
            listCardápio = new ListBox();
            listPedido = new ListBox();
            btnFinalizar = new Button();
            lblTotal = new Label();
            lblQuantidade = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            txtDinheiro = new TextBox();
            lblDinheiro = new Label();
            lblTroco = new Label();
            rbtnDinheiro = new RadioButton();
            rbtnDébito = new RadioButton();
            rbtnCrédito = new RadioButton();
            rbtnPix = new RadioButton();
            checkViagem = new CheckBox();
            btnIrBalcão = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            pictureBox6 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            txtQuantidade = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(230, 255, 0);
            btnAdicionar.BackgroundImageLayout = ImageLayout.Center;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(401, 144);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 36);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(230, 255, 0);
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(511, 144);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(98, 36);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // listCardápio
            // 
            listCardápio.BackColor = Color.FromArgb(202, 196, 183);
            listCardápio.BorderStyle = BorderStyle.FixedSingle;
            listCardápio.Font = new Font("Segoe UI", 10F);
            listCardápio.FormattingEnabled = true;
            listCardápio.ItemHeight = 17;
            listCardápio.Location = new Point(21, 161);
            listCardápio.Name = "listCardápio";
            listCardápio.Size = new Size(250, 172);
            listCardápio.TabIndex = 2;
            listCardápio.SelectedIndexChanged += listCardápio_SelectedIndexChanged;
            listCardápio.KeyDown += listCardápio_KeyDown;
            // 
            // listPedido
            // 
            listPedido.BackColor = Color.FromArgb(202, 196, 183);
            listPedido.BorderStyle = BorderStyle.FixedSingle;
            listPedido.FormattingEnabled = true;
            listPedido.ItemHeight = 15;
            listPedido.Location = new Point(292, 198);
            listPedido.Name = "listPedido";
            listPedido.Size = new Size(176, 137);
            listPedido.TabIndex = 3;
            listPedido.SelectedIndexChanged += listPedido_SelectedIndexChanged;
            // 
            // btnFinalizar
            // 
            btnFinalizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFinalizar.BackColor = Color.FromArgb(202, 196, 183);
            btnFinalizar.Cursor = Cursors.Hand;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            btnFinalizar.Location = new Point(604, 381);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(116, 45);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(243, 241, 238);
            lblTotal.Font = new Font("Agrandir", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(292, 381);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(79, 36);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.FromArgb(230, 255, 0);
            lblQuantidade.BorderStyle = BorderStyle.FixedSingle;
            lblQuantidade.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.ForeColor = Color.Black;
            lblQuantidade.Location = new Point(289, 128);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(103, 23);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade:";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.FromArgb(202, 196, 183);
            txtCliente.Cursor = Cursors.IBeam;
            txtCliente.Location = new Point(510, 222);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(92, 23);
            txtCliente.TabIndex = 10;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.FromArgb(202, 196, 183);
            lblCliente.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            lblCliente.Location = new Point(511, 198);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(68, 21);
            lblCliente.TabIndex = 11;
            lblCliente.Text = "Cliente:";
            // 
            // txtDinheiro
            // 
            txtDinheiro.BackColor = Color.FromArgb(202, 196, 183);
            txtDinheiro.Location = new Point(635, 281);
            txtDinheiro.Name = "txtDinheiro";
            txtDinheiro.Size = new Size(92, 23);
            txtDinheiro.TabIndex = 14;
            txtDinheiro.Visible = false;
            txtDinheiro.KeyDown += txtDinheiro_KeyDown;
            // 
            // lblDinheiro
            // 
            lblDinheiro.AutoSize = true;
            lblDinheiro.BackColor = Color.FromArgb(202, 196, 183);
            lblDinheiro.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            lblDinheiro.Location = new Point(635, 258);
            lblDinheiro.Name = "lblDinheiro";
            lblDinheiro.Size = new Size(78, 21);
            lblDinheiro.TabIndex = 15;
            lblDinheiro.Text = "Dinheiro:";
            lblDinheiro.Visible = false;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.FromArgb(202, 196, 183);
            lblTroco.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            lblTroco.Location = new Point(635, 317);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(57, 21);
            lblTroco.TabIndex = 16;
            lblTroco.Text = "Troco:";
            lblTroco.Visible = false;
            lblTroco.Click += lblTroco_Click;
            // 
            // rbtnDinheiro
            // 
            rbtnDinheiro.AutoSize = true;
            rbtnDinheiro.BackColor = Color.FromArgb(202, 196, 183);
            rbtnDinheiro.Font = new Font("Agrandir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnDinheiro.Location = new Point(511, 255);
            rbtnDinheiro.Name = "rbtnDinheiro";
            rbtnDinheiro.Size = new Size(86, 24);
            rbtnDinheiro.TabIndex = 17;
            rbtnDinheiro.TabStop = true;
            rbtnDinheiro.Text = "Dinheiro";
            rbtnDinheiro.UseVisualStyleBackColor = false;
            rbtnDinheiro.CheckedChanged += rbtnDinheiro_CheckedChanged;
            // 
            // rbtnDébito
            // 
            rbtnDébito.AutoSize = true;
            rbtnDébito.BackColor = Color.FromArgb(202, 196, 183);
            rbtnDébito.Font = new Font("Agrandir", 11F, FontStyle.Bold);
            rbtnDébito.Location = new Point(511, 280);
            rbtnDébito.Name = "rbtnDébito";
            rbtnDébito.Size = new Size(75, 24);
            rbtnDébito.TabIndex = 20;
            rbtnDébito.TabStop = true;
            rbtnDébito.Text = "Débito";
            rbtnDébito.UseVisualStyleBackColor = false;
            rbtnDébito.CheckedChanged += rbtnDébito_CheckedChanged;
            // 
            // rbtnCrédito
            // 
            rbtnCrédito.AutoSize = true;
            rbtnCrédito.BackColor = Color.FromArgb(202, 196, 183);
            rbtnCrédito.Font = new Font("Agrandir", 11F, FontStyle.Bold);
            rbtnCrédito.Location = new Point(511, 305);
            rbtnCrédito.Name = "rbtnCrédito";
            rbtnCrédito.Size = new Size(82, 24);
            rbtnCrédito.TabIndex = 21;
            rbtnCrédito.TabStop = true;
            rbtnCrédito.Text = "Crédito";
            rbtnCrédito.UseVisualStyleBackColor = false;
            rbtnCrédito.CheckedChanged += rbtnCrédito_CheckedChanged;
            // 
            // rbtnPix
            // 
            rbtnPix.AutoSize = true;
            rbtnPix.BackColor = Color.FromArgb(202, 196, 183);
            rbtnPix.Font = new Font("Agrandir", 11F, FontStyle.Bold);
            rbtnPix.Location = new Point(511, 330);
            rbtnPix.Name = "rbtnPix";
            rbtnPix.Size = new Size(49, 24);
            rbtnPix.TabIndex = 22;
            rbtnPix.TabStop = true;
            rbtnPix.Text = "Pix";
            rbtnPix.UseVisualStyleBackColor = false;
            rbtnPix.CheckedChanged += rbtnPix_CheckedChanged;
            // 
            // checkViagem
            // 
            checkViagem.AutoSize = true;
            checkViagem.BackColor = Color.FromArgb(202, 196, 183);
            checkViagem.Cursor = Cursors.Hand;
            checkViagem.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            checkViagem.Location = new Point(635, 207);
            checkViagem.Name = "checkViagem";
            checkViagem.Size = new Size(85, 25);
            checkViagem.TabIndex = 23;
            checkViagem.Text = "Viagem";
            checkViagem.UseVisualStyleBackColor = false;
            // 
            // btnIrBalcão
            // 
            btnIrBalcão.BackColor = Color.FromArgb(230, 255, 0);
            btnIrBalcão.Cursor = Cursors.Hand;
            btnIrBalcão.FlatAppearance.BorderSize = 0;
            btnIrBalcão.FlatStyle = FlatStyle.Flat;
            btnIrBalcão.Location = new Point(757, 404);
            btnIrBalcão.Name = "btnIrBalcão";
            btnIrBalcão.Size = new Size(31, 34);
            btnIrBalcão.TabIndex = 29;
            btnIrBalcão.Text = ">";
            btnIrBalcão.UseVisualStyleBackColor = false;
            btnIrBalcão.Click += btnIrBalcão_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(241, 241, 241);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(661, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(43, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(84, 23);
            dateTimePicker1.TabIndex = 32;
            dateTimePicker1.Value = new DateTime(2025, 5, 28, 11, 4, 56, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(41, 41);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(86, 23);
            dateTimePicker2.TabIndex = 33;
            dateTimePicker2.Value = new DateTime(2025, 5, 28, 11, 4, 56, 0);
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-3, -110);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(806, 225);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(310, 92);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 23);
            numericUpDown1.TabIndex = 36;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(202, 196, 183);
            txtQuantidade.Location = new Point(292, 152);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(98, 23);
            txtQuantidade.TabIndex = 7;
            txtQuantidade.KeyDown += txtQuantidade_KeyDown;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(btnIrBalcão);
            Controls.Add(checkViagem);
            Controls.Add(rbtnPix);
            Controls.Add(rbtnCrédito);
            Controls.Add(rbtnDébito);
            Controls.Add(rbtnDinheiro);
            Controls.Add(lblTroco);
            Controls.Add(lblDinheiro);
            Controls.Add(txtDinheiro);
            Controls.Add(lblCliente);
            Controls.Add(txtCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(txtQuantidade);
            Controls.Add(lblTotal);
            Controls.Add(btnFinalizar);
            Controls.Add(listPedido);
            Controls.Add(listCardápio);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(pictureBox6);
            Name = "Vendas";
            Text = "-";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnRemover;
        private ListBox listCardápio;
        private ListBox listPedido;
        private Button btnFinalizar;
        private Label lblTotal;
        private Label lblQuantidade;
        private TextBox txtCliente;
        private Label lblCliente;
        private TextBox txtDinheiro;
        private Label lblDinheiro;
        private Label lblTroco;
        private RadioButton rbtnDinheiro;
        private RadioButton rbtnDébito;
        private RadioButton rbtnCrédito;
        private RadioButton rbtnPix;
        private CheckBox checkViagem;
        private Button btnIrBalcão;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox6;
        private NumericUpDown numericUpDown1;
        private TextBox txtQuantidade;
    }
}
