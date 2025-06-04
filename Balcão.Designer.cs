namespace Cantina
{
    partial class Balcão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcão));
            btnIrVendas = new Button();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnHistórico = new Button();
            listBalcão = new ListBox();
            listDetalhesBalcão = new ListBox();
            listHistórico = new ListBox();
            listDetalhesHistórico = new ListBox();
            btnFecharPedido = new Button();
            lblBalcão = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIrVendas
            // 
            btnIrVendas.Location = new Point(12, 12);
            btnIrVendas.Name = "btnIrVendas";
            btnIrVendas.Size = new Size(37, 36);
            btnIrVendas.TabIndex = 1;
            btnIrVendas.Text = "<";
            btnIrVendas.UseVisualStyleBackColor = true;
            btnIrVendas.Click += btnIrVendas_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-3, -110);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(806, 225);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(241, 241, 241);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(661, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnHistórico
            // 
            btnHistórico.BackColor = Color.FromArgb(230, 255, 0);
            btnHistórico.BackgroundImageLayout = ImageLayout.Center;
            btnHistórico.Cursor = Cursors.Hand;
            btnHistórico.FlatStyle = FlatStyle.Flat;
            btnHistórico.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            btnHistórico.ForeColor = Color.Black;
            btnHistórico.Location = new Point(699, 121);
            btnHistórico.Name = "btnHistórico";
            btnHistórico.Size = new Size(89, 32);
            btnHistórico.TabIndex = 36;
            btnHistórico.Text = "Histórico";
            btnHistórico.UseVisualStyleBackColor = false;
            btnHistórico.Click += btnHistórico_Click;
            // 
            // listBalcão
            // 
            listBalcão.BackColor = Color.FromArgb(202, 196, 183);
            listBalcão.BorderStyle = BorderStyle.FixedSingle;
            listBalcão.Font = new Font("Inter", 9.75F);
            listBalcão.FormattingEnabled = true;
            listBalcão.ItemHeight = 18;
            listBalcão.Location = new Point(51, 172);
            listBalcão.Name = "listBalcão";
            listBalcão.Size = new Size(175, 164);
            listBalcão.TabIndex = 39;
            listBalcão.SelectedIndexChanged += listBalcão_SelectedIndexChanged;
            // 
            // listDetalhesBalcão
            // 
            listDetalhesBalcão.BackColor = Color.FromArgb(202, 196, 183);
            listDetalhesBalcão.BorderStyle = BorderStyle.FixedSingle;
            listDetalhesBalcão.Font = new Font("Inter", 9.75F);
            listDetalhesBalcão.FormattingEnabled = true;
            listDetalhesBalcão.ItemHeight = 18;
            listDetalhesBalcão.Location = new Point(309, 172);
            listDetalhesBalcão.Name = "listDetalhesBalcão";
            listDetalhesBalcão.Size = new Size(250, 164);
            listDetalhesBalcão.TabIndex = 40;
            // 
            // listHistórico
            // 
            listHistórico.BackColor = Color.FromArgb(202, 196, 183);
            listHistórico.BorderStyle = BorderStyle.FixedSingle;
            listHistórico.Font = new Font("Inter", 9.75F);
            listHistórico.FormattingEnabled = true;
            listHistórico.ItemHeight = 18;
            listHistórico.Location = new Point(178, 163);
            listHistórico.Name = "listHistórico";
            listHistórico.Size = new Size(211, 200);
            listHistórico.TabIndex = 41;
            listHistórico.Visible = false;
            listHistórico.SelectedIndexChanged += listHistórico_SelectedIndexChanged;
            // 
            // listDetalhesHistórico
            // 
            listDetalhesHistórico.BackColor = Color.FromArgb(202, 196, 183);
            listDetalhesHistórico.BorderStyle = BorderStyle.FixedSingle;
            listDetalhesHistórico.Font = new Font("Inter", 9.75F);
            listDetalhesHistórico.FormattingEnabled = true;
            listDetalhesHistórico.ItemHeight = 18;
            listDetalhesHistórico.Location = new Point(446, 163);
            listDetalhesHistórico.Name = "listDetalhesHistórico";
            listDetalhesHistórico.Size = new Size(211, 200);
            listDetalhesHistórico.TabIndex = 42;
            listDetalhesHistórico.Visible = false;
            // 
            // btnFecharPedido
            // 
            btnFecharPedido.BackColor = Color.FromArgb(230, 255, 0);
            btnFecharPedido.BackgroundImageLayout = ImageLayout.Center;
            btnFecharPedido.Cursor = Cursors.Hand;
            btnFecharPedido.FlatStyle = FlatStyle.Flat;
            btnFecharPedido.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            btnFecharPedido.ForeColor = Color.Black;
            btnFecharPedido.Location = new Point(446, 388);
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Size = new Size(89, 32);
            btnFecharPedido.TabIndex = 43;
            btnFecharPedido.Text = "Entregar";
            btnFecharPedido.UseVisualStyleBackColor = false;
            btnFecharPedido.Click += btnFecharPedido_Click;
            // 
            // lblBalcão
            // 
            lblBalcão.AutoSize = true;
            lblBalcão.Font = new Font("Agrandir", 30F, FontStyle.Bold);
            lblBalcão.Location = new Point(164, 58);
            lblBalcão.Name = "lblBalcão";
            lblBalcão.Size = new Size(149, 54);
            lblBalcão.TabIndex = 44;
            lblBalcão.Text = "Balcão";
            // 
            // Balcão
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(800, 450);
            Controls.Add(lblBalcão);
            Controls.Add(btnFecharPedido);
            Controls.Add(listDetalhesBalcão);
            Controls.Add(listBalcão);
            Controls.Add(btnHistórico);
            Controls.Add(pictureBox1);
            Controls.Add(btnIrVendas);
            Controls.Add(pictureBox6);
            Controls.Add(listHistórico);
            Controls.Add(listDetalhesHistórico);
            Name = "Balcão";
            Text = "Balcão";
            Load += Balcão_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIrVendas;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Button btnHistórico;
        private ListBox listBalcão;
        private ListBox listDetalhesBalcão;
        private ListBox listHistórico;
        private ListBox listDetalhesHistórico;
        private Button btnFecharPedido;
        private Label lblBalcão;
    }
}