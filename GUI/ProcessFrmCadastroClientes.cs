using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroClientes
    { 
        public void AvaliarDadosCliente()
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
                    txtCodOp.Text = "00001";
                    txtNomeOp.Text = "VENDA PARA AM";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO ZFM";
                }
                else if (radOutrasUF.Checked)
                {
                    txtCodOp.Text = "00002";
                    txtNomeOp.Text = "VENDA PARA FORA AM";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO FORA ZFM";
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
                    txtCodOp.Text = "00001";
                    txtNomeOp.Text = "VENDA PARA AM";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO ZFM";
                }
                else if (radOutrasUF.Checked)
                {
                    txtCodOp.Text = "00002";
                    txtNomeOp.Text = "VENDA PARA FORA AM";
                    txtCodPreco.Text = "0001";
                    txtNomePreco.Text = "PREÇO FORA ZFM";
                }
            }
            else if (radEstrangeiro.Checked)
            {
                radConfigNaoContribuinte.Checked = true;
                lblMsgEstrangeiro.Visible = true;
                lblMsgPessoaJuridica.Visible = false;
                chkPrestadorServico.Visible = false;
                txtCodOp.Text = "00003";
                txtNomeOp.Text = "VENDA PARA ESTRANGEIRO NO BRASIL";
                txtCodPreco.Text = "0001";
                txtNomePreco.Text = "PREÇO ZFM";

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
                txtCodOp.Text = "00004";
                txtNomeOp.Text = "VENDA PARA ÓRGÃO PUBLICO FEDERAL";
                txtCodPreco.Text = "0001";
                txtNomePreco.Text = "PREÇO ZFM";
            }

            if (chkPrestadorServico.Checked)
            {
                chkConfigPrestadorServico.Checked = true;
            }

        }
    }
}
