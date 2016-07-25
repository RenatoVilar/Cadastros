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
            string codcalcRevProdNac = "00001";
            string calcRevProdNac = "REVENDA PROD NACIONAL";
            string codcalcRevProdImp = "00002";
            string calcRevProdImp = "REVENDA PROD IMP ZFM";
            string codRevProdSubTrib = "00003";
            string calcRevProdSubTrib = "REVENDA PROD NAC/IMP/NACIONALIZADO COM ST";
            string codRevProdImpNac = "00008";
            string calcRevProdImpNac = "REVENDA DE PROD IMP NACIONALIZADO";
            string codInsumos = "00010";
            string calcInsumos = "INSUMOS";

            txtCodClassFiscal.Text = txtCodNCM.Text;
            txtNomeClassFiscal.Text = txtNomeNCM.Text;
            txtPisCstEntrada.Text = "70";
            txtCofinsCstEntrada.Text = "70";

            if (radForBrasileiro.Checked || radForZFM.Checked)
            {
                if (picAutopecasOK.Visible == true)
                {
                    txtAliquotaPisPerc.Text = "0,00";
                    txtPisCstSaida.Text = "04";
                    txtAliquotaCofinsPerc.Text = "0,00";
                    txtCofinsCstSaida.Text = "04";
                }

                else
                {
                    txtAliquotaPisPerc.Text = "0,65";
                    txtPisCstSaida.Text = "01";
                    txtAliquotaCofinsPerc.Text = "3,00";
                    txtCofinsCstSaida.Text = "01";
                }
            }

            else if (radForEstrangeiro.Checked)
            {
                if (picAutopecasOK.Visible == true)
                {
                    txtAliquotaPisPerc.Text = "2,30";
                    txtPisCstSaida.Text = "02";
                    txtAliquotaCofinsPerc.Text = "10,80";
                    txtCofinsCstSaida.Text = "02";
                }
                else
                {
                    txtAliquotaPisPerc.Text = "0,65";
                    txtPisCstSaida.Text = "01";
                    txtAliquotaCofinsPerc.Text = "3,00";
                    txtCofinsCstSaida.Text = "01";
                }
            }

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
                chkCompoBCdaCsll.Checked = true;
                chkCalcCOFINS.Checked = true;
                chkCalcPIS.Checked = true;

                if (radForBrasileiro.Checked)
                {
                    if (radOrigemNac.Checked)
                    {
                        txtCodCalcICMS.Text = codcalcRevProdNac;
                        txtNomeCalcICMS.Text = calcRevProdNac;

                        if (picSubTribOK.Visible == true)
                        {
                            txtCodCalcICMS.Text = codRevProdSubTrib;
                            txtNomeCalcICMS.Text = calcRevProdSubTrib;
                        }

                        if (radSim.Checked)
                        {
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoPrefixo;
                            txtFormatoCod2.Text = formatoCodigo;
                            txtCodCalcICMS.Text = codcalcRevProdNac;
                            txtNomeCalcICMS.Text = calcRevProdNac;
                            txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Subst Tributária.";
                        }

                        radOrigem0.Checked = true;
                       
                    }

                    else if (radOrigemImp.Checked)
                    {
                        txtCodCalcICMS.Text = codRevProdImpNac;
                        txtNomeCalcICMS.Text = calcRevProdImpNac;

                        if (picSubTribOK.Visible == true)
                        {
                            txtCodCalcICMS.Text = codRevProdSubTrib;
                            txtNomeCalcICMS.Text = calcRevProdSubTrib;
                        }

                        if (radSim.Checked)
                        {
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoPrefixo;
                            txtFormatoCod2.Text = formatoCodigo;
                            txtCodCalcICMS.Text = codRevProdImpNac;
                            txtNomeCalcICMS.Text = calcRevProdImpNac;
                            txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Autopeças.";
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
                    txtCodCalcICMS.Text = codcalcRevProdImp;
                    txtNomeCalcICMS.Text = calcRevProdImp;

                    if (picSubTribOK.Visible == true)
                    {
                        txtCodCalcICMS.Text = codRevProdSubTrib;
                        txtNomeCalcICMS.Text = calcRevProdSubTrib;
                    }

                    if (radSim.Checked)
                    {
                        txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoZFM;
                        txtFormatoCod2.Text = formatoCodigo;
                        txtCodCalcICMS.Text = codcalcRevProdImp;
                        txtNomeCalcICMS.Text = calcRevProdImp;
                        txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Autopeças.";
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
                        txtCodCalcICMS.Text = codcalcRevProdNac;
                        txtNomeCalcICMS.Text = calcRevProdNac;
                        txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoNAC;
                        txtFormatoCod2.Text = formatoCodigo;

                        if (picSubTribOK.Visible == true)
                        {
                            txtCodCalcICMS.Text = codRevProdSubTrib;
                            txtNomeCalcICMS.Text = calcRevProdSubTrib;
                        }

                        if (radSim.Checked)
                        {
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoYAL + Environment.NewLine + formatoSufixoMAL;
                            txtFormatoCod2.Text = formatoCodigo;
                            txtCodCalcICMS.Text = codcalcRevProdNac;
                            txtNomeCalcICMS.Text = calcRevProdNac;
                            txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Autopeças.";
                        }

                        radOrigem0.Checked = true;
                    }

                    if (radOrigemImp.Checked)
                    {
                        txtCodCalcICMS.Text = codRevProdImpNac;
                        txtNomeCalcICMS.Text = calcRevProdImpNac;
                        txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoZFMMot;
                        txtFormatoCod2.Text = formatoCodigo;

                        if (picSubTribOK.Visible == true)
                        {
                            txtCodCalcICMS.Text = codRevProdSubTrib;
                            txtNomeCalcICMS.Text = calcRevProdSubTrib;
                        }

                        if (radSim.Checked)
                        {
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoYAL + Environment.NewLine + formatoSufixoMAL;
                            txtFormatoCod2.Text = formatoCodigo;
                            txtCodCalcICMS.Text = codRevProdImpNac;
                            txtNomeCalcICMS.Text = calcRevProdImpNac;
                            txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Autopeças.";
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
            }

            else if (radMatPrima.Checked)
            {
                txtCodProd1.Text = "000005";
                txtNomeCodProd1.Text = "FORNECEDOR";
                txtFormatoCod1.Text = formatoCodigo;
                chkRepasse.Checked = false;
                radFaturamento.Checked = false;
                radOrigem4.Checked = true;
                txtCodCalcICMS.Text = codInsumos;
                txtNomeCalcICMS.Text = calcInsumos;
            }

            else if (radInsumos.Checked)
            {
                txtCodProd1.Text = "000005";
                txtNomeCodProd1.Text = "FORNECEDOR";
                txtFormatoCod1.Text = formatoCodigo;
                chkRepasse.Checked = false;
                radFaturamento.Checked = false;
                txtCodCalcICMS.Text = codInsumos;
                txtNomeCalcICMS.Text = calcInsumos;
            }
        }

        
    }
}


