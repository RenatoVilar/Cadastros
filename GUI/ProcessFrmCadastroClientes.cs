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
