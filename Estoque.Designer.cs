namespace Cantina
{
    partial class Estoque
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
            listEstoque = new ListBox();
            btnCarregar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // listEstoque
            // 
            listEstoque.FormattingEnabled = true;
            listEstoque.ItemHeight = 15;
            listEstoque.Location = new Point(180, 111);
            listEstoque.Name = "listEstoque";
            listEstoque.Size = new Size(169, 244);
            listEstoque.TabIndex = 0;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(496, 119);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(100, 33);
            btnCarregar.TabIndex = 1;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(496, 182);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 33);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnCarregar);
            Controls.Add(listEstoque);
            Name = "Estoque";
            Text = "Estoque";
            Load += Estoque_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listEstoque;
        private Button btnCarregar;
        private Button btnSalvar;
    }
}