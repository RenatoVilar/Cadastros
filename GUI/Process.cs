using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public partial class frmCadastroProdutos
    {
        public void ProcessFinalidade()
        {
            //Verifica a Finalidade do Produto
            string formatoCodigo = "Código do Doc de Entrada.";
            string formatoPrefixo = "Prefixo: 426 - Para Outras Entradas YAMAHA.";
            string formatoSufixoYAL = "Sufixo: YAL - Para YAMAHA.";
            string formatoSufixoMAL = "Sufixo: MAL - Para MERCURY.";
            string formatoSufixoZFM = "Sufixo: ZFM - Para todos Fornecedores.";
            string formatoSufixoZFMMot = "Sufixo: ZFM - Para Motores.";
            string formatoSufixoNAC = "Sufixo: NAC - Para Motores.";

            if (radRevenda.Checked)
            {
                txtCodProd1.Text = "000001";
                txtCodProd2.Text = "000005";
                txtNomeCodProd1.Text = "LOJA";
                txtNomeCodProd2.Text = "FORNECEDOR";
                txtFormatoCod1.Text = formatoCodigo;
                txtFormatoCod2.Text = formatoCodigo;
                chkRepasse.Checked = true;
                radFaturamento.Checked = true;

                if (radForBrasileiro.Checked)
                {
                    if (radOrigemNac.Checked)
                    {
                        if (radSim.Checked)
                        {
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoPrefixo;
                            txtFormatoCod2.Text = formatoCodigo;
                        }

                        radOrigem0.Checked = true;
                    }

                    else if (radOrigemImp.Checked)
                    {
                        if (radSim.Checked)
                        {
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoPrefixo;
                            txtFormatoCod2.Text = formatoCodigo;
                        }

                        if (picSemSimilarOK.Visible == true)
                        {
                            radOrigem7.Checked = true;
                        }
                        else
                        {
                            radOrigem2.Checked = true;
                        }
                    }
                }

                if (radForEstrangeiro.Checked) 
                {
                    if (radSim.Checked)
                    {
                        txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoZFM;
                        txtFormatoCod2.Text = formatoCodigo;
                    }

                    if (picSemSimilarOK.Visible == true)
                    {
                        radOrigem6.Checked = true;
                    }
                    else
                    {
                        radOrigem1.Checked = true;
                    }
                }

                if (radForZFM.Checked)
                {
                    if (radOrigemNac.Checked)
                    {
                        txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoNAC;
                        txtFormatoCod2.Text = formatoCodigo;
                        radOrigem0.Checked = true;
                    }

                    if (radOrigemImp.Checked)
                    {
                        if (picSemSimilarOK.Visible == true)
                        {
                            radOrigem7.Checked = true;
                        }
                        else
                        {
                            radOrigem2.Checked = true;
                        }

                        txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoZFMMot;
                        txtFormatoCod2.Text = formatoCodigo;
                    }

                    if (radOrigemNac.Checked || radOrigemImp.Checked)
                    {
                        if (radSim.Checked)
                        {
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoYAL + Environment.NewLine + formatoSufixoMAL;
                            txtFormatoCod2.Text = formatoCodigo;
                        }
                    }
                }
            }

            else if (radMatPrima.Checked)
            {
                txtCodProd1.Text = "000005";
                txtNomeCodProd1.Text = "FORNECEDOR";
                txtFormatoCod1.Text = formatoCodigo;
                chkRepasse.Checked = false;
                radFaturamento.Checked = false;
                radOrigem4.Checked = true;
            }

            else if (radInsumos.Checked)
            {
                txtCodProd1.Text = "000005";
                txtNomeCodProd1.Text = "FORNECEDOR";
                txtFormatoCod1.Text = formatoCodigo;
                chkRepasse.Checked = false;
                radFaturamento.Checked = false;
            }
        }

        
    }
}


