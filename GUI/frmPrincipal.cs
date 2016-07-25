﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTpProduto frm = new frmCadastroTpProduto();
            frm.ShowDialog();
            frm.Dispose();

        }

        private void nCMsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroNCM frm = new frmCadastroNCM();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void cálculoDeICMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCalcICMS frm = new frmCadastroCalcICMS();
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
    }
}