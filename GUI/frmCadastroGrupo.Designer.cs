namespace GUI
{
    partial class frmCadastroGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroGrupo));
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.txtGrupoID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radInsumos = new System.Windows.Forms.RadioButton();
            this.radMatPrima = new System.Windows.Forms.RadioButton();
            this.radRevenda = new System.Windows.Forms.RadioButton();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.groupBox1);
            this.pnDados.Controls.Add(this.txtNomeGrupo);
            this.pnDados.Controls.Add(this.txtGrupoID);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGrupo.Location = new System.Drawing.Point(43, 135);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(512, 26);
            this.txtNomeGrupo.TabIndex = 1;
            // 
            // txtGrupoID
            // 
            this.txtGrupoID.Enabled = false;
            this.txtGrupoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupoID.Location = new System.Drawing.Point(43, 70);
            this.txtGrupoID.Name = "txtGrupoID";
            this.txtGrupoID.Size = new System.Drawing.Size(100, 26);
            this.txtGrupoID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radInsumos);
            this.groupBox1.Controls.Add(this.radMatPrima);
            this.groupBox1.Controls.Add(this.radRevenda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finalidade";
            // 
            // radInsumos
            // 
            this.radInsumos.AutoSize = true;
            this.radInsumos.Location = new System.Drawing.Point(280, 30);
            this.radInsumos.Name = "radInsumos";
            this.radInsumos.Size = new System.Drawing.Size(95, 24);
            this.radInsumos.TabIndex = 2;
            this.radInsumos.Text = "Insumos";
            this.radInsumos.UseVisualStyleBackColor = true;
            // 
            // radMatPrima
            // 
            this.radMatPrima.AutoSize = true;
            this.radMatPrima.Location = new System.Drawing.Point(141, 30);
            this.radMatPrima.Name = "radMatPrima";
            this.radMatPrima.Size = new System.Drawing.Size(112, 24);
            this.radMatPrima.TabIndex = 1;
            this.radMatPrima.Text = "Mat. Prima";
            this.radMatPrima.UseVisualStyleBackColor = true;
            // 
            // radRevenda
            // 
            this.radRevenda.AutoSize = true;
            this.radRevenda.Checked = true;
            this.radRevenda.Location = new System.Drawing.Point(16, 30);
            this.radRevenda.Name = "radRevenda";
            this.radRevenda.Size = new System.Drawing.Size(98, 24);
            this.radRevenda.TabIndex = 0;
            this.radRevenda.TabStop = true;
            this.radRevenda.Text = "Revenda";
            this.radRevenda.UseVisualStyleBackColor = true;
            // 
            // frmCadastroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroGrupo";
            this.Text = "frmCadastroGrupo";
            this.Load += new System.EventHandler(this.frmCadastroGrupo_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.TextBox txtGrupoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radInsumos;
        private System.Windows.Forms.RadioButton radMatPrima;
        private System.Windows.Forms.RadioButton radRevenda;
    }
}