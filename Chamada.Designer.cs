namespace Cantina
{
    partial class Chamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamada));
            lblChamada = new Label();
            pictureBox1 = new PictureBox();
            btnIrVendas = new Button();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblChamada
            // 
            lblChamada.AutoSize = true;
            lblChamada.Font = new Font("Agrandir", 30F, FontStyle.Bold);
            lblChamada.Location = new Point(164, 58);
            lblChamada.Name = "lblChamada";
            lblChamada.Size = new Size(200, 54);
            lblChamada.TabIndex = 40;
            lblChamada.Text = "Chamada";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(241, 241, 241);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(661, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // btnIrVendas
            // 
            btnIrVendas.Location = new Point(12, 12);
            btnIrVendas.Name = "btnIrVendas";
            btnIrVendas.Size = new Size(37, 36);
            btnIrVendas.TabIndex = 37;
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
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(800, 450);
            Controls.Add(lblChamada);
            Controls.Add(pictureBox1);
            Controls.Add(btnIrVendas);
            Controls.Add(pictureBox6);
            Name = "Chamada";
            Text = "Chamada";
            Load += Chamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChamada;
        private PictureBox pictureBox1;
        private Button btnIrVendas;
        private PictureBox pictureBox6;
    }
}