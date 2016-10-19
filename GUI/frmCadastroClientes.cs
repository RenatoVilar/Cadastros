using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
            chkPrestadorServico.Visible = false;

            for (int i = 0; i < grpTipo.Controls.Count; i++)
            {
                RadioButton rdb = (RadioButton)grpTipo.Controls[i];
                rdb.CheckedChanged += new EventHandler(Rdb_CheckedChanged);
            }
        }

        private void Rdb_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rdb in grpTipo.Controls)
            {
                if (rdb.Name == "radJuridica")
                {
                    chkPrestadorServico.Visible = true;
                }
                else chkPrestadorServico.Visible = false;
            }
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            TreeNode mnuEnderecos= trePrincipal.Nodes.Add("Endereços...");
            TreeNode mnuAdicionais = trePrincipal.Nodes.Add("Adicionais...");
            TreeNode mnuCadastros= trePrincipal.Nodes.Add("Cadastros...");
            TreeNode mnuCaracteristicas = trePrincipal.Nodes.Add("Características...");

            pnlEndereco.Visible = true;
        }

        private void trePrincipal_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode myNode;

            myNode = e.Node;

            switch (myNode.Index)
            {
                case 0:
                    pnlEndereco.Visible = true;
                    pnlAdicionais.Visible = false;
                    pnlCadastros.Visible = false;
                    pnlCaracteristicas.Visible = false;
                    break;
                case 1:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = true;
                    pnlCadastros.Visible = false;
                    pnlCaracteristicas.Visible = false;
                    break;
                case 2:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = false;
                    pnlCadastros.Visible = true;
                    pnlCaracteristicas.Visible = false;
                    break;
                case 3:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = false;
                    pnlCadastros.Visible = false;
                    pnlCaracteristicas.Visible = true;
                    break;
            }
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            Design modelo = new Design();
            modelo.LimparTela(pnlAdicionais);
            modelo.LimparTela(pnlCadastros);
            modelo.LimparTela(pnlCaracteristicas);
            modelo.LimparTela(pnlEndereco);
            AvaliarDadosCliente();
        }

        private void radJuridica_Click(object sender, EventArgs e)
        {
            chkPrestadorServico.Visible = true;
        }

        private void radFisica_CheckedChanged(object sender, EventArgs e)
        {
            chkPrestadorServico.Visible = false;
        }

        private void AvaliarDadosCliente()
        {
            if (radFisica.Checked)
            {
                radNaoContribuinte.Checked = true;
                radConfigNaoContribuinte.Checked = true;
                lblMsgEstrangeiro.Visible = false;
                lblMsgPessoaJuridica.Visible = false;
                chkPrestadorServico.Visible = false;

                if (radUFAm.Checked)
                {
                    txtCodOp.Text = "000001";
                    txtNomeOp.Text = "COM - VENDA PARA NÃO CONTRIBUINTE NO AM";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO VAREJO ZFM";
                }
                else if (radOutrasUF.Checked)
                {
                    txtCodOp.Text = "000094";
                    txtNomeOp.Text = "COM - VENDA PARA NÃO CONTRIBUINTE FORA AM";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO VAREJO ZFM";
                }
            }
            else if (radJuridica.Checked)
            {
                chkPrestadorServico.Visible = true;

                if (radContribuinte.Checked)
                {
                    radConfigContribuinte.Checked = true;
                    lblMsgEstrangeiro.Visible = false;
                    lblMsgPessoaJuridica.Visible = false;

                }
                else
                {
                    radConfigNaoContribuinte.Checked = true;
                    lblMsgEstrangeiro.Visible = false;
                    lblMsgPessoaJuridica.Visible = true;
                }

                if (radUFAm.Checked)
                {
                    txtCodOp.Text = "000013";
                    txtNomeOp.Text = "COM - VENDA PARA CONTRIBUINTE";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO VAREJO ZFM";
                }
                else if (radOutrasUF.Checked)
                {
                    txtCodOp.Text = "000013";
                    txtNomeOp.Text = "COM - VENDA PARA CONTRIBUINTE";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO VAREJO FORA ZFM";
                }
            }
            else if (radEstrangeiro.Checked)
            {
                radConfigNaoContribuinte.Checked = true;
                lblMsgEstrangeiro.Visible = true;
                lblMsgPessoaJuridica.Visible = false;
                chkPrestadorServico.Visible = false;
                txtCodOp.Text = "000098";
                txtNomeOp.Text = "COM - VENDA PARA ESTRANGEIROS NO BRASIL";
                txtCodPreco.Text = "0001";
                txtNomePreco.Text = "PREÇO VAREJO ZFM";

            }
            else if (radOrgaoPubFed.Checked)
            {
                radNaoContribuinte.Checked = true;
                radConfigNaoContribuinte.Checked = true;
                chkEntidadeDaAdmFederal.Checked = true;
                chkPrestadorServico.Visible = false;
                lblMsgEstrangeiro.Visible = false;
                lblMsgPessoaJuridica.Visible = false;
                txtCodCaracteristica.Text = "00001";
                txtNomeCaracteristica.Text = "NÃO COBRAR JUROS";
                txtCodOp.Text = "0000132";
                txtNomeOp.Text = "COM - VENDA PARA ÓRGÃO PUBLICO POR EMPENHO";
                txtCodPreco.Text = "0001";
                txtNomePreco.Text = "PREÇO VAREJO ZFM";
            }

            if (chkPrestadorServico.Checked)
            {
                chkConfigPrestadorServico.Checked = true;
            }

        }
    }
}
