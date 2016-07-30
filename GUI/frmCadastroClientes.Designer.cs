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
            this.txtCodPreco = new System.Windows.Forms.TextBox();
            this.txtNomePreco = new System.Windows.Forms.TextBox();
            this.trePrincipal = new System.Windows.Forms.TreeView();
            this.pnlEndereco = new System.Windows.Forms.Panel();
            this.lblMsgPessoaJuridica = new System.Windows.Forms.Label();
            this.lblMsgEstrangeiro = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radConfigNaoContribuinte = new System.Windows.Forms.RadioButton();
            this.radConfigContribuinte = new System.Windows.Forms.RadioButton();
            this.radConfigIsentoIE = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAdicionais = new System.Windows.Forms.Panel();
            this.txtCodOp = new System.Windows.Forms.TextBox();
            this.txtNomeOp = new System.Windows.Forms.TextBox();
            this.chkEntidadeDaAdmFederal = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkConfigPrestadorServico = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCadastros = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlCaracteristicas = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodCaracteristica = new System.Windows.Forms.TextBox();
            this.txtNomeCaracteristica = new System.Windows.Forms.TextBox();
            this.chkPrestadorServico = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpFornecedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlAdicionais.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlCadastros.SuspendLayout();
            this.pnlCaracteristicas.SuspendLayout();
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
            // txtCodPreco
            // 
            this.txtCodPreco.Enabled = false;
            this.txtCodPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPreco.Location = new System.Drawing.Point(26, 153);
            this.txtCodPreco.Name = "txtCodPreco";
            this.txtCodPreco.Size = new System.Drawing.Size(75, 26);
            this.txtCodPreco.TabIndex = 36;
            // 
            // txtNomePreco
            // 
            this.txtNomePreco.Enabled = false;
            this.txtNomePreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePreco.Location = new System.Drawing.Point(109, 153);
            this.txtNomePreco.Name = "txtNomePreco";
            this.txtNomePreco.Size = new System.Drawing.Size(316, 26);
            this.txtNomePreco.TabIndex = 37;
            // 
            // trePrincipal
            // 
            this.trePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trePrincipal.Location = new System.Drawing.Point(12, 187);
            this.trePrincipal.Name = "trePrincipal";
            this.trePrincipal.Size = new System.Drawing.Size(155, 200);
            this.trePrincipal.TabIndex = 38;
            this.trePrincipal.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trePrincipal_NodeMouseClick);
            // 
            // pnlEndereco
            // 
            this.pnlEndereco.Controls.Add(this.lblMsgPessoaJuridica);
            this.pnlEndereco.Controls.Add(this.lblMsgEstrangeiro);
            this.pnlEndereco.Controls.Add(this.groupBox3);
            this.pnlEndereco.Controls.Add(this.label2);
            this.pnlEndereco.Location = new System.Drawing.Point(174, 187);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Size = new System.Drawing.Size(598, 363);
            this.pnlEndereco.TabIndex = 39;
            this.pnlEndereco.Visible = false;
            // 
            // lblMsgPessoaJuridica
            // 
            this.lblMsgPessoaJuridica.AutoSize = true;
            this.lblMsgPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgPessoaJuridica.Location = new System.Drawing.Point(10, 129);
            this.lblMsgPessoaJuridica.Name = "lblMsgPessoaJuridica";
            this.lblMsgPessoaJuridica.Size = new System.Drawing.Size(365, 40);
            this.lblMsgPessoaJuridica.TabIndex = 38;
            this.lblMsgPessoaJuridica.Text = "Pessoa Juridica Não Contribuinte.\r\nConfirmar se possui IE no site www.sintegra.go" +
    "v.br";
            this.lblMsgPessoaJuridica.Visible = false;
            // 
            // lblMsgEstrangeiro
            // 
            this.lblMsgEstrangeiro.AutoSize = true;
            this.lblMsgEstrangeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgEstrangeiro.Location = new System.Drawing.Point(14, 179);
            this.lblMsgEstrangeiro.Name = "lblMsgEstrangeiro";
            this.lblMsgEstrangeiro.Size = new System.Drawing.Size(338, 100);
            this.lblMsgEstrangeiro.TabIndex = 37;
            this.lblMsgEstrangeiro.Text = "Estrangeiros: \r\n- O CPF deve ficar em branco.\r\n- Logradouro: Alterar para endereç" +
    "o do cliente.\r\n- Bairro deve ser 99999-99.\r\n- UF deve ser EX.\r\n";
            this.lblMsgEstrangeiro.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radConfigNaoContribuinte);
            this.groupBox3.Controls.Add(this.radConfigContribuinte);
            this.groupBox3.Controls.Add(this.radConfigIsentoIE);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 56);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Contribuição do ICMS";
            // 
            // radConfigNaoContribuinte
            // 
            this.radConfigNaoContribuinte.AutoSize = true;
            this.radConfigNaoContribuinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radConfigNaoContribuinte.Location = new System.Drawing.Point(418, 18);
            this.radConfigNaoContribuinte.Name = "radConfigNaoContribuinte";
            this.radConfigNaoContribuinte.Size = new System.Drawing.Size(146, 24);
            this.radConfigNaoContribuinte.TabIndex = 17;
            this.radConfigNaoContribuinte.Text = "Não Contribuinte";
            this.radConfigNaoContribuinte.UseVisualStyleBackColor = true;
            // 
            // radConfigContribuinte
            // 
            this.radConfigContribuinte.AutoSize = true;
            this.radConfigContribuinte.Checked = true;
            this.radConfigContribuinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radConfigContribuinte.Location = new System.Drawing.Point(15, 18);
            this.radConfigContribuinte.Name = "radConfigContribuinte";
            this.radConfigContribuinte.Size = new System.Drawing.Size(157, 24);
            this.radConfigContribuinte.TabIndex = 15;
            this.radConfigContribuinte.TabStop = true;
            this.radConfigContribuinte.Text = "Contribuinte ICMS";
            this.radConfigContribuinte.UseVisualStyleBackColor = true;
            // 
            // radConfigIsentoIE
            // 
            this.radConfigIsentoIE.AutoSize = true;
            this.radConfigIsentoIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radConfigIsentoIE.Location = new System.Drawing.Point(193, 18);
            this.radConfigIsentoIE.Name = "radConfigIsentoIE";
            this.radConfigIsentoIE.Size = new System.Drawing.Size(204, 24);
            this.radConfigIsentoIE.TabIndex = 16;
            this.radConfigIsentoIE.Text = "Contribuinte Isento de IE";
            this.radConfigIsentoIE.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clicar em Editar o Endereço  \r\nInformar o tipo de Contribuição do ICMS conforme a" +
    "baixo:\r\n\r\n";
            // 
            // pnlAdicionais
            // 
            this.pnlAdicionais.Controls.Add(this.label5);
            this.pnlAdicionais.Controls.Add(this.groupBox4);
            this.pnlAdicionais.Controls.Add(this.chkEntidadeDaAdmFederal);
            this.pnlAdicionais.Location = new System.Drawing.Point(174, 187);
            this.pnlAdicionais.Name = "pnlAdicionais";
            this.pnlAdicionais.Size = new System.Drawing.Size(598, 363);
            this.pnlAdicionais.TabIndex = 40;
            this.pnlAdicionais.Visible = false;
            // 
            // txtCodOp
            // 
            this.txtCodOp.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.txtCodOp.Enabled = false;
            this.txtCodOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodOp.Location = new System.Drawing.Point(26, 83);
            this.txtCodOp.Name = "txtCodOp";
            this.txtCodOp.Size = new System.Drawing.Size(75, 26);
            this.txtCodOp.TabIndex = 36;
            // 
            // txtNomeOp
            // 
            this.txtNomeOp.Enabled = false;
            this.txtNomeOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeOp.Location = new System.Drawing.Point(109, 83);
            this.txtNomeOp.Name = "txtNomeOp";
            this.txtNomeOp.Size = new System.Drawing.Size(473, 26);
            this.txtNomeOp.TabIndex = 37;
            // 
            // chkEntidadeDaAdmFederal
            // 
            this.chkEntidadeDaAdmFederal.AutoSize = true;
            this.chkEntidadeDaAdmFederal.Enabled = false;
            this.chkEntidadeDaAdmFederal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntidadeDaAdmFederal.Location = new System.Drawing.Point(9, 64);
            this.chkEntidadeDaAdmFederal.Name = "chkEntidadeDaAdmFederal";
            this.chkEntidadeDaAdmFederal.Size = new System.Drawing.Size(280, 20);
            this.chkEntidadeDaAdmFederal.TabIndex = 0;
            this.chkEntidadeDaAdmFederal.Text = "Entidade da administração pública federal";
            this.chkEntidadeDaAdmFederal.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.chkConfigPrestadorServico);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(581, 86);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(248, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Retenção de tributos e contribuições ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(20, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(290, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Retenção de documentos de qualquer valor";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkConfigPrestadorServico
            // 
            this.chkConfigPrestadorServico.AutoSize = true;
            this.chkConfigPrestadorServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfigPrestadorServico.Location = new System.Drawing.Point(319, 45);
            this.chkConfigPrestadorServico.Name = "chkConfigPrestadorServico";
            this.chkConfigPrestadorServico.Size = new System.Drawing.Size(255, 20);
            this.chkConfigPrestadorServico.TabIndex = 2;
            this.chkConfigPrestadorServico.Text = "Pessoa jurídica prestadora de serviço";
            this.chkConfigPrestadorServico.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(495, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aliq. I.R. pessoas juridicas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Preencher os seguintes campos:";
            // 
            // pnlCadastros
            // 
            this.pnlCadastros.Controls.Add(this.label8);
            this.pnlCadastros.Controls.Add(this.label7);
            this.pnlCadastros.Controls.Add(this.txtCodPreco);
            this.pnlCadastros.Controls.Add(this.label6);
            this.pnlCadastros.Controls.Add(this.txtCodOp);
            this.pnlCadastros.Controls.Add(this.txtNomePreco);
            this.pnlCadastros.Controls.Add(this.txtNomeOp);
            this.pnlCadastros.Location = new System.Drawing.Point(174, 187);
            this.pnlCadastros.Name = "pnlCadastros";
            this.pnlCadastros.Size = new System.Drawing.Size(598, 363);
            this.pnlCadastros.TabIndex = 41;
            this.pnlCadastros.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Preencher os seguintes campos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Operação para notas fiscals";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Preço";
            // 
            // pnlCaracteristicas
            // 
            this.pnlCaracteristicas.Controls.Add(this.label10);
            this.pnlCaracteristicas.Controls.Add(this.txtCodCaracteristica);
            this.pnlCaracteristicas.Controls.Add(this.label9);
            this.pnlCaracteristicas.Controls.Add(this.txtNomeCaracteristica);
            this.pnlCaracteristicas.Location = new System.Drawing.Point(174, 187);
            this.pnlCaracteristicas.Name = "pnlCaracteristicas";
            this.pnlCaracteristicas.Size = new System.Drawing.Size(598, 363);
            this.pnlCaracteristicas.TabIndex = 41;
            this.pnlCaracteristicas.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Preencher os seguintes campos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Características";
            // 
            // txtCodCaracteristica
            // 
            this.txtCodCaracteristica.Enabled = false;
            this.txtCodCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCaracteristica.Location = new System.Drawing.Point(13, 99);
            this.txtCodCaracteristica.Name = "txtCodCaracteristica";
            this.txtCodCaracteristica.Size = new System.Drawing.Size(75, 26);
            this.txtCodCaracteristica.TabIndex = 40;
            // 
            // txtNomeCaracteristica
            // 
            this.txtNomeCaracteristica.Enabled = false;
            this.txtNomeCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCaracteristica.Location = new System.Drawing.Point(96, 99);
            this.txtNomeCaracteristica.Name = "txtNomeCaracteristica";
            this.txtNomeCaracteristica.Size = new System.Drawing.Size(473, 26);
            this.txtNomeCaracteristica.TabIndex = 41;
            // 
            // chkPrestadorServico
            // 
            this.chkPrestadorServico.AutoSize = true;
            this.chkPrestadorServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrestadorServico.Location = new System.Drawing.Point(383, 136);
            this.chkPrestadorServico.Name = "chkPrestadorServico";
            this.chkPrestadorServico.Size = new System.Drawing.Size(175, 24);
            this.chkPrestadorServico.TabIndex = 42;
            this.chkPrestadorServico.Text = "Prestador de Serviço";
            this.chkPrestadorServico.UseVisualStyleBackColor = true;
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.chkPrestadorServico);
            this.Controls.Add(this.trePrincipal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlEndereco);
            this.Controls.Add(this.pnlCaracteristicas);
            this.Controls.Add(this.pnlCadastros);
            this.Controls.Add(this.pnlAdicionais);
            this.Name = "frmCadastroClientes";
            this.Text = "frmCadastroClientes";
            this.Load += new System.EventHandler(this.frmCadastroClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFornecedor.ResumeLayout(false);
            this.grpFornecedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlAdicionais.ResumeLayout(false);
            this.pnlAdicionais.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlCadastros.ResumeLayout(false);
            this.pnlCadastros.PerformLayout();
            this.pnlCaracteristicas.ResumeLayout(false);
            this.pnlCaracteristicas.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCodPreco;
        private System.Windows.Forms.TextBox txtNomePreco;
        private System.Windows.Forms.TreeView trePrincipal;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.Panel pnlAdicionais;
        private System.Windows.Forms.TextBox txtCodOp;
        private System.Windows.Forms.TextBox txtNomeOp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radConfigNaoContribuinte;
        private System.Windows.Forms.RadioButton radConfigContribuinte;
        private System.Windows.Forms.RadioButton radConfigIsentoIE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsgPessoaJuridica;
        private System.Windows.Forms.Label lblMsgEstrangeiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox chkConfigPrestadorServico;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkEntidadeDaAdmFederal;
        private System.Windows.Forms.Panel pnlCadastros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCaracteristicas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodCaracteristica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeCaracteristica;
        private System.Windows.Forms.CheckBox chkPrestadorServico;
    }
}