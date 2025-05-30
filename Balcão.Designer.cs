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
            listView1 = new ListView();
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
            // listView1
            // 
            listView1.Location = new Point(67, 161);
            listView1.Name = "listView1";
            listView1.Size = new Size(327, 216);
            listView1.TabIndex = 33;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Balcão
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(btnIrVendas);
            Controls.Add(pictureBox6);
            Name = "Balcão";
            Text = "Balcão";
            Load += Balcão_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnIrVendas;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private ListBox listBalcão;
        private ListView listView1;
    }
}