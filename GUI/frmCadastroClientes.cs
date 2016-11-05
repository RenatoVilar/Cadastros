using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();

            radFisica.CheckedChanged += new EventHandler(Rdb_CheckedChanged);
            radJuridica.CheckedChanged += new EventHandler(Rdb_CheckedChanged);
            radEstrangeiro.CheckedChanged += new EventHandler(Rdb_CheckedChanged);
            radOrgaoPubFed.CheckedChanged += new EventHandler(Rdb_CheckedChanged);
        }

        private void Rdb_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rdb in grpTipo.Controls)
            {
                if (radJuridica.Checked)
                {
                    chkPrestadorServico.Enabled = true;
                }
                else 
                    chkPrestadorServico.Enabled = false;

            }
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            TreeNode mnuEnderecos= trePrincipal.Nodes.Add("Endereços...");
            TreeNode mnuAdicionais = trePrincipal.Nodes.Add("Adicionais...");
            TreeNode mnuCadastros= trePrincipal.Nodes.Add("Cadastros...");
            TreeNode mnuCaracteristicas = trePrincipal.Nodes.Add("Características...");

            pnlEndereco.Visible = true;

            radContribuinte.Enabled = false;

            chkPrestadorServico.Enabled = false;
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

        private void radFisica_CheckedChanged(object sender, EventArgs e)
        {
            //chkPrestadorServico.Enabled = false;
            radNaoContribuinte.Checked = true;
            radContribuinte.Enabled = false;
            radUFAm.Enabled = true;
            radOutrasUF.Enabled = true;
        }

        private void radJuridica_Click(object sender, EventArgs e)
        {
            //chkPrestadorServico.Enabled = true;
            radContribuinte.Enabled = true;
            radUFAm.Enabled = true;
            radOutrasUF.Enabled = true;
        }

        private void radEstrangeiro_Click(object sender, EventArgs e)
        {
            //chkPrestadorServico.Enabled = false;
            radContribuinte.Enabled = false;
            radUFAm.Enabled = false;
            radOutrasUF.Enabled = false;
        }

        private void radOrgaoPubFed_Click(object sender, EventArgs e)
        {
            //chkPrestadorServico.Enabled = false;
            radContribuinte.Enabled = false;
            radUFAm.Enabled = true;
            radOutrasUF.Enabled = true;
        }

        private void AvaliarDadosCliente()
        {
            if (radFisica.Checked)
            {
                radConfigNaoContribuinte.Checked = true;
                lblMsgEstrangeiro.Visible = false;
                lblMsgPessoaJuridica.Visible = false;
                chkConfigPrestadorServico.Checked = false;

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
                if (radContribuinte.Checked)
                {
                    radConfigContribuinte.Checked = true;

                    lblMsgEstrangeiro.Visible = false;
                    lblMsgPessoaJuridica.Visible = false;

                    txtCodOp.Text = "000002";
                    txtNomeOp.Text = "COM - VENDA PARA CONTRIBUINTE";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO VAREJO FORA ZFM";
                }
                else if (radNaoContribuinte.Checked)
                {
                    radConfigNaoContribuinte.Checked = true;

                    lblMsgEstrangeiro.Visible = false;
                    lblMsgPessoaJuridica.Visible = true;

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

                if (chkPrestadorServico.Checked)
                {
                    chkConfigPrestadorServico.Checked = true;
                }
            }
            else if (radEstrangeiro.Checked)
            {
                radConfigNaoContribuinte.Checked = true;
                lblMsgEstrangeiro.Visible = true;
                lblMsgPessoaJuridica.Visible = false;
                txtCodOp.Text = "000098";
                txtNomeOp.Text = "COM - VENDA PARA ESTRANGEIROS NO BRASIL";
                txtCodPreco.Text = "0001";
                txtNomePreco.Text = "PREÇO VAREJO ZFM";

            }
            else if (radOrgaoPubFed.Checked)
            {
                radConfigNaoContribuinte.Checked = true;
                chkEntidadeDaAdmFederal.Checked = true;
                chkConfigPrestadorServico.Checked = false;
                lblMsgEstrangeiro.Visible = false;
                lblMsgPessoaJuridica.Visible = false;
                txtCodCaracteristica.Text = "00001";
                txtNomeCaracteristica.Text = "NÃO COBRAR JUROS";
                txtCodOp.Text = "0000132";
                txtNomeOp.Text = "COM - VENDA PARA ÓRGÃO PUBLICO POR EMPENHO";
                txtCodPreco.Text = "0001";
                txtNomePreco.Text = "PREÇO VAREJO ZFM";
            }
        }
    }
}
