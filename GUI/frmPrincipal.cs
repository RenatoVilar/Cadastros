﻿using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nCMsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroNCM frm = new frmCadastroNCM();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroGrupo frm = new frmCadastroGrupo();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnCadastraProdutos_Click(object sender, EventArgs e)
        {
            frmCadastroProdutos frm = new frmCadastroProdutos();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            frmCadastroClientes frm = new frmCadastroClientes();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void atualizarNCMPorLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarNcmLote frm = new frmAlterarNcmLote();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
