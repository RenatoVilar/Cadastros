namespace GUI
{
    partial class frmLocalizarNCM
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
            this.cboLocalizarNCM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(142, 32);
            this.txtPesquisar.Size = new System.Drawing.Size(430, 26);
            this.txtPesquisar.TabIndex = 1;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // cboLocalizarNCM
            // 
            this.cboLocalizarNCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocalizarNCM.FormattingEnabled = true;
            this.cboLocalizarNCM.Location = new System.Drawing.Point(12, 32);
            this.cboLocalizarNCM.Name = "cboLocalizarNCM";
            this.cboLocalizarNCM.Size = new System.Drawing.Size(121, 26);
            this.cboLocalizarNCM.TabIndex = 0;
            // 
            // frmLocalizarNCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 341);
            this.Controls.Add(this.cboLocalizarNCM);
            this.Name = "frmLocalizarNCM";
            this.Text = "Localizar NCM";
            this.Load += new System.EventHandler(this.frmLocalizarNCM_Load);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnLocalizar, 0);
            this.Controls.SetChildIndex(this.cboLocalizarNCM, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLocalizarNCM;
    }
}