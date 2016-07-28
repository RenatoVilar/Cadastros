namespace GUI
{
    partial class frmCadastroNCM
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeNCM = new System.Windows.Forms.TextBox();
            this.txtCodNCM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkST = new System.Windows.Forms.CheckBox();
            this.chkAutopecas = new System.Windows.Forms.CheckBox();
            this.chkSemSimilar = new System.Windows.Forms.CheckBox();
            this.txtCest = new System.Windows.Forms.Label();
            this.mtxtCest = new System.Windows.Forms.MaskedTextBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.mtxtCest);
            this.pnDados.Controls.Add(this.txtCest);
            this.pnDados.Controls.Add(this.chkSemSimilar);
            this.pnDados.Controls.Add(this.chkAutopecas);
            this.pnDados.Controls.Add(this.chkST);
            this.pnDados.Controls.Add(this.txtNomeNCM);
            this.pnDados.Controls.Add(this.txtCodNCM);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NCM";
            // 
            // txtNomeNCM
            // 
            this.txtNomeNCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNCM.Location = new System.Drawing.Point(131, 44);
            this.txtNomeNCM.Name = "txtNomeNCM";
            this.txtNomeNCM.Size = new System.Drawing.Size(604, 26);
            this.txtNomeNCM.TabIndex = 5;
            // 
            // txtCodNCM
            // 
            this.txtCodNCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodNCM.Location = new System.Drawing.Point(25, 44);
            this.txtCodNCM.Name = "txtCodNCM";
            this.txtCodNCM.Size = new System.Drawing.Size(100, 26);
            this.txtCodNCM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Substituição Tributária";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Autopeças";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sem Similar Nacional";
            // 
            // chkST
            // 
            this.chkST.AutoSize = true;
            this.chkST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkST.Location = new System.Drawing.Point(25, 163);
            this.chkST.Name = "chkST";
            this.chkST.Size = new System.Drawing.Size(15, 14);
            this.chkST.TabIndex = 6;
            this.chkST.UseVisualStyleBackColor = true;
            // 
            // chkAutopecas
            // 
            this.chkAutopecas.AutoSize = true;
            this.chkAutopecas.Location = new System.Drawing.Point(25, 202);
            this.chkAutopecas.Name = "chkAutopecas";
            this.chkAutopecas.Size = new System.Drawing.Size(15, 14);
            this.chkAutopecas.TabIndex = 7;
            this.chkAutopecas.UseVisualStyleBackColor = true;
            // 
            // chkSemSimilar
            // 
            this.chkSemSimilar.AutoSize = true;
            this.chkSemSimilar.Location = new System.Drawing.Point(25, 241);
            this.chkSemSimilar.Name = "chkSemSimilar";
            this.chkSemSimilar.Size = new System.Drawing.Size(15, 14);
            this.chkSemSimilar.TabIndex = 8;
            this.chkSemSimilar.UseVisualStyleBackColor = true;
            // 
            // txtCest
            // 
            this.txtCest.AutoSize = true;
            this.txtCest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCest.Location = new System.Drawing.Point(25, 83);
            this.txtCest.Name = "txtCest";
            this.txtCest.Size = new System.Drawing.Size(55, 20);
            this.txtCest.TabIndex = 9;
            this.txtCest.Text = "CEST";
            // 
            // mtxtCest
            // 
            this.mtxtCest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCest.Location = new System.Drawing.Point(25, 115);
            this.mtxtCest.Name = "mtxtCest";
            this.mtxtCest.Size = new System.Drawing.Size(100, 26);
            this.mtxtCest.TabIndex = 11;
            this.mtxtCest.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCEST_MaskInputRejected);
            this.mtxtCest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCest_KeyPress);
            // 
            // frmCadastroNCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroNCM";
            this.Text = "Cadastro de NCMs";
            this.Load += new System.EventHandler(this.frmCadastroNCM_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeNCM;
        private System.Windows.Forms.TextBox txtCodNCM;
        private System.Windows.Forms.CheckBox chkAutopecas;
        private System.Windows.Forms.CheckBox chkST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSemSimilar;
        private System.Windows.Forms.Label txtCest;
        private System.Windows.Forms.MaskedTextBox mtxtCest;
    }
}