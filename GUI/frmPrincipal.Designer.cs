namespace GUI
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nCMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoDeICMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastraProdutos = new System.Windows.Forms.Button();
            this.btnCadastrarClientes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nCMsToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.cálculoDeICMSToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // nCMsToolStripMenuItem
            // 
            this.nCMsToolStripMenuItem.Name = "nCMsToolStripMenuItem";
            this.nCMsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nCMsToolStripMenuItem.Text = "NCMs";
            this.nCMsToolStripMenuItem.Click += new System.EventHandler(this.nCMsToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // cálculoDeICMSToolStripMenuItem
            // 
            this.cálculoDeICMSToolStripMenuItem.Name = "cálculoDeICMSToolStripMenuItem";
            this.cálculoDeICMSToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cálculoDeICMSToolStripMenuItem.Text = "Cálculo de ICMS";
            this.cálculoDeICMSToolStripMenuItem.Click += new System.EventHandler(this.cálculoDeICMSToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // btnCadastraProdutos
            // 
            this.btnCadastraProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraProdutos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastraProdutos.Location = new System.Drawing.Point(147, 174);
            this.btnCadastraProdutos.Name = "btnCadastraProdutos";
            this.btnCadastraProdutos.Size = new System.Drawing.Size(491, 58);
            this.btnCadastraProdutos.TabIndex = 1;
            this.btnCadastraProdutos.Text = "Cadastrar Produtos";
            this.btnCadastraProdutos.UseVisualStyleBackColor = true;
            this.btnCadastraProdutos.Click += new System.EventHandler(this.btnCadastraProdutos_Click);
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClientes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarClientes.Location = new System.Drawing.Point(147, 289);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Size = new System.Drawing.Size(491, 58);
            this.btnCadastrarClientes.TabIndex = 2;
            this.btnCadastrarClientes.Text = "Cadastrar Clientes";
            this.btnCadastrarClientes.UseVisualStyleBackColor = true;
            this.btnCadastrarClientes.Click += new System.EventHandler(this.btnCadastrarClientes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCadastrarClientes);
            this.Controls.Add(this.btnCadastraProdutos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros de Produtos e Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nCMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculoDeICMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button btnCadastraProdutos;
        private System.Windows.Forms.Button btnCadastrarClientes;
    }
}