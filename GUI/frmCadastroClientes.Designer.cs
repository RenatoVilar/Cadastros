namespace GUI
{
    partial class frmCadastroClientes
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Endereços...");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Adicionais...");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Cadastros...");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Características...");
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOrgaoPubFed = new System.Windows.Forms.RadioButton();
            this.radEstrangeiro = new System.Windows.Forms.RadioButton();
            this.radJuridica = new System.Windows.Forms.RadioButton();
            this.radFisica = new System.Windows.Forms.RadioButton();
            this.grpFornecedor = new System.Windows.Forms.GroupBox();
            this.radUFAm = new System.Windows.Forms.RadioButton();
            this.radOutrasUF = new System.Windows.Forms.RadioButton();
            this.radContribuinte = new System.Windows.Forms.RadioButton();
            this.radNaoContribuinte = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodProd1 = new System.Windows.Forms.TextBox();
            this.txtNomeCodProd1 = new System.Windows.Forms.TextBox();
            this.trePrincipal = new System.Windows.Forms.TreeView();
            this.pnlEndereco = new System.Windows.Forms.Panel();
            this.pnlAdicionais = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grpFornecedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            this.pnlAdicionais.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOrgaoPubFed);
            this.groupBox1.Controls.Add(this.radEstrangeiro);
            this.groupBox1.Controls.Add(this.radJuridica);
            this.groupBox1.Controls.Add(this.radFisica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 56);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // radOrgaoPubFed
            // 
            this.radOrgaoPubFed.AutoSize = true;
            this.radOrgaoPubFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOrgaoPubFed.Location = new System.Drawing.Point(319, 23);
            this.radOrgaoPubFed.Name = "radOrgaoPubFed";
            this.radOrgaoPubFed.Size = new System.Drawing.Size(184, 24);
            this.radOrgaoPubFed.TabIndex = 3;
            this.radOrgaoPubFed.Text = "Orgão Público Federal";
            this.radOrgaoPubFed.UseVisualStyleBackColor = true;
            // 
            // radEstrangeiro
            // 
            this.radEstrangeiro.AutoSize = true;
            this.radEstrangeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEstrangeiro.Location = new System.Drawing.Point(193, 23);
            this.radEstrangeiro.Name = "radEstrangeiro";
            this.radEstrangeiro.Size = new System.Drawing.Size(109, 24);
            this.radEstrangeiro.TabIndex = 2;
            this.radEstrangeiro.Text = "Estrangeiro";
            this.radEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // radJuridica
            // 
            this.radJuridica.AutoSize = true;
            this.radJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJuridica.Location = new System.Drawing.Point(96, 23);
            this.radJuridica.Name = "radJuridica";
            this.radJuridica.Size = new System.Drawing.Size(81, 24);
            this.radJuridica.TabIndex = 1;
            this.radJuridica.Text = "Jurídica";
            this.radJuridica.UseVisualStyleBackColor = true;
            // 
            // radFisica
            // 
            this.radFisica.AutoSize = true;
            this.radFisica.Checked = true;
            this.radFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFisica.Location = new System.Drawing.Point(14, 23);
            this.radFisica.Name = "radFisica";
            this.radFisica.Size = new System.Drawing.Size(68, 24);
            this.radFisica.TabIndex = 0;
            this.radFisica.TabStop = true;
            this.radFisica.Text = "Física";
            this.radFisica.UseVisualStyleBackColor = true;
            // 
            // grpFornecedor
            // 
            this.grpFornecedor.Controls.Add(this.radUFAm);
            this.grpFornecedor.Controls.Add(this.radOutrasUF);
            this.grpFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFornecedor.Location = new System.Drawing.Point(561, 58);
            this.grpFornecedor.Name = "grpFornecedor";
            this.grpFornecedor.Size = new System.Drawing.Size(177, 56);
            this.grpFornecedor.TabIndex = 34;
            this.grpFornecedor.TabStop = false;
            this.grpFornecedor.Text = "UF";
            // 
            // radUFAm
            // 
            this.radUFAm.AutoSize = true;
            this.radUFAm.Checked = true;
            this.radUFAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUFAm.Location = new System.Drawing.Point(10, 18);
            this.radUFAm.Name = "radUFAm";
            this.radUFAm.Size = new System.Drawing.Size(51, 24);
            this.radUFAm.TabIndex = 15;
            this.radUFAm.TabStop = true;
            this.radUFAm.Text = "AM";
            this.radUFAm.UseVisualStyleBackColor = true;
            // 
            // radOutrasUF
            // 
            this.radOutrasUF.AutoSize = true;
            this.radOutrasUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOutrasUF.Location = new System.Drawing.Point(71, 18);
            this.radOutrasUF.Name = "radOutrasUF";
            this.radOutrasUF.Size = new System.Drawing.Size(101, 24);
            this.radOutrasUF.TabIndex = 16;
            this.radOutrasUF.Text = "Outras UF";
            this.radOutrasUF.UseVisualStyleBackColor = true;
            // 
            // radContribuinte
            // 
            this.radContribuinte.AutoSize = true;
            this.radContribuinte.Checked = true;
            this.radContribuinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radContribuinte.Location = new System.Drawing.Point(10, 18);
            this.radContribuinte.Name = "radContribuinte";
            this.radContribuinte.Size = new System.Drawing.Size(113, 24);
            this.radContribuinte.TabIndex = 15;
            this.radContribuinte.TabStop = true;
            this.radContribuinte.Text = "Contribuinte";
            this.radContribuinte.UseVisualStyleBackColor = true;
            // 
            // radNaoContribuinte
            // 
            this.radNaoContribuinte.AutoSize = true;
            this.radNaoContribuinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNaoContribuinte.Location = new System.Drawing.Point(140, 18);
            this.radNaoContribuinte.Name = "radNaoContribuinte";
            this.radNaoContribuinte.Size = new System.Drawing.Size(146, 24);
            this.radNaoContribuinte.TabIndex = 16;
            this.radNaoContribuinte.Text = "Não Contribuinte";
            this.radNaoContribuinte.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radContribuinte);
            this.groupBox2.Controls.Add(this.radNaoContribuinte);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 56);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ICMS";
            // 
            // txtCodProd1
            // 
            this.txtCodProd1.Enabled = false;
            this.txtCodProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd1.Location = new System.Drawing.Point(31, 69);
            this.txtCodProd1.Name = "txtCodProd1";
            this.txtCodProd1.Size = new System.Drawing.Size(75, 22);
            this.txtCodProd1.TabIndex = 36;
            // 
            // txtNomeCodProd1
            // 
            this.txtNomeCodProd1.Enabled = false;
            this.txtNomeCodProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCodProd1.Location = new System.Drawing.Point(110, 69);
            this.txtNomeCodProd1.Name = "txtNomeCodProd1";
            this.txtNomeCodProd1.Size = new System.Drawing.Size(140, 22);
            this.txtNomeCodProd1.TabIndex = 37;
            // 
            // trePrincipal
            // 
            this.trePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trePrincipal.Location = new System.Drawing.Point(12, 187);
            this.trePrincipal.Name = "trePrincipal";
            treeNode5.Name = "mnuEnderecos";
            treeNode5.Text = "Endereços...";
            treeNode6.Name = "mnuAdicionais";
            treeNode6.Text = "Adicionais...";
            treeNode7.Name = "mnuCadastros";
            treeNode7.Text = "Cadastros...";
            treeNode8.Name = "mnuCaracteristicas";
            treeNode8.Text = "Características...";
            this.trePrincipal.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.trePrincipal.Size = new System.Drawing.Size(155, 200);
            this.trePrincipal.TabIndex = 38;
            this.trePrincipal.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trePrincipal_NodeMouseClick);
            this.trePrincipal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trePrincipal_MouseClick);
            // 
            // pnlEndereco
            // 
            this.pnlEndereco.Controls.Add(this.groupBox3);
            this.pnlEndereco.Controls.Add(this.label2);
            this.pnlEndereco.Location = new System.Drawing.Point(174, 187);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Size = new System.Drawing.Size(598, 363);
            this.pnlEndereco.TabIndex = 39;
            // 
            // pnlAdicionais
            // 
            this.pnlAdicionais.Controls.Add(this.txtCodProd1);
            this.pnlAdicionais.Controls.Add(this.txtNomeCodProd1);
            this.pnlAdicionais.Controls.Add(this.textBox1);
            this.pnlAdicionais.Controls.Add(this.textBox2);
            this.pnlAdicionais.Location = new System.Drawing.Point(778, 187);
            this.pnlAdicionais.Name = "pnlAdicionais";
            this.pnlAdicionais.Size = new System.Drawing.Size(598, 363);
            this.pnlAdicionais.TabIndex = 40;
            this.pnlAdicionais.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(110, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "Editar o Endereço do Cliente \r\n\r\nInformar o tipo de Contribuição do ICMS\r\n\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 56);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Contribuição do ICMS";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(15, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 24);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Contribuinte ICMS";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(193, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(204, 24);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "Contribuinte Isento de IE";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(418, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(146, 24);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.Text = "Não Contribuinte";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.pnlAdicionais);
            this.Controls.Add(this.pnlEndereco);
            this.Controls.Add(this.trePrincipal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroClientes";
            this.Text = "frmCadastroClientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFornecedor.ResumeLayout(false);
            this.grpFornecedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            this.pnlAdicionais.ResumeLayout(false);
            this.pnlAdicionais.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOrgaoPubFed;
        private System.Windows.Forms.RadioButton radEstrangeiro;
        private System.Windows.Forms.RadioButton radJuridica;
        protected System.Windows.Forms.RadioButton radFisica;
        private System.Windows.Forms.GroupBox grpFornecedor;
        private System.Windows.Forms.RadioButton radUFAm;
        private System.Windows.Forms.RadioButton radOutrasUF;
        private System.Windows.Forms.RadioButton radContribuinte;
        private System.Windows.Forms.RadioButton radNaoContribuinte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodProd1;
        private System.Windows.Forms.TextBox txtNomeCodProd1;
        private System.Windows.Forms.TreeView trePrincipal;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.Panel pnlAdicionais;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
    }
}