namespace Cantina
{
    partial class Cozinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cozinha));
            pictureBox1 = new PictureBox();
            btnIrVendas = new Button();
            pictureBox6 = new PictureBox();
            lblCozinha = new Label();
            listCozinha = new ListBox();
            label2 = new Label();
            listDetalhesPedido = new ListBox();
            btnFecharPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(241, 241, 241);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(661, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // btnIrVendas
            // 
            btnIrVendas.Location = new Point(12, 12);
            btnIrVendas.Name = "btnIrVendas";
            btnIrVendas.Size = new Size(37, 36);
            btnIrVendas.TabIndex = 33;
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
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            // 
            // lblCozinha
            // 
            lblCozinha.AutoSize = true;
            lblCozinha.Font = new Font("Agrandir", 30F, FontStyle.Bold);
            lblCozinha.Location = new Point(164, 58);
            lblCozinha.Name = "lblCozinha";
            lblCozinha.Size = new Size(171, 54);
            lblCozinha.TabIndex = 36;
            lblCozinha.Text = "Cozinha";
            // 
            // listCozinha
            // 
            listCozinha.BackColor = Color.FromArgb(202, 196, 183);
            listCozinha.BorderStyle = BorderStyle.FixedSingle;
            listCozinha.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listCozinha.FormattingEnabled = true;
            listCozinha.ItemHeight = 18;
            listCozinha.Location = new Point(26, 169);
            listCozinha.Name = "listCozinha";
            listCozinha.Size = new Size(309, 218);
            listCozinha.TabIndex = 40;
            listCozinha.SelectedIndexChanged += listCozinha_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir", 20F, FontStyle.Bold);
            label2.Location = new Point(26, 130);
            label2.Name = "label2";
            label2.Size = new Size(115, 36);
            label2.TabIndex = 42;
            label2.Text = "Pedidos";
            // 
            // listDetalhesPedido
            // 
            listDetalhesPedido.BackColor = Color.FromArgb(202, 196, 183);
            listDetalhesPedido.BorderStyle = BorderStyle.FixedSingle;
            listDetalhesPedido.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listDetalhesPedido.FormattingEnabled = true;
            listDetalhesPedido.ItemHeight = 18;
            listDetalhesPedido.Location = new Point(376, 187);
            listDetalhesPedido.Name = "listDetalhesPedido";
            listDetalhesPedido.Size = new Size(220, 164);
            listDetalhesPedido.TabIndex = 43;
            // 
            // btnFecharPedido
            // 
            btnFecharPedido.BackColor = Color.FromArgb(230, 255, 0);
            btnFecharPedido.BackgroundImageLayout = ImageLayout.Center;
            btnFecharPedido.Cursor = Cursors.Hand;
            btnFecharPedido.FlatStyle = FlatStyle.Flat;
            btnFecharPedido.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            btnFecharPedido.ForeColor = Color.Black;
            btnFecharPedido.Location = new Point(399, 382);
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Size = new Size(89, 32);
            btnFecharPedido.TabIndex = 44;
            btnFecharPedido.Text = "Entregar";
            btnFecharPedido.UseVisualStyleBackColor = false;
            btnFecharPedido.Click += btnFecharPedido_Click;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(800, 450);
            Controls.Add(btnFecharPedido);
            Controls.Add(listDetalhesPedido);
            Controls.Add(label2);
            Controls.Add(listCozinha);
            Controls.Add(lblCozinha);
            Controls.Add(pictureBox1);
            Controls.Add(btnIrVendas);
            Controls.Add(pictureBox6);
            Name = "Cozinha";
            Text = "Cozinha";
            Load += Cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnIrVendas;
        private PictureBox pictureBox6;
        private Label lblCozinha;
        private ListBox listCozinha;
        private Label label2;
        private ListBox listDetalhesPedido;
        private Button btnFecharPedido;
    }
}