using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Apagar
    {
        //private void AvaliarDadosProdutos()
        //{
        //    //Verifica a Finalidade do Produto
        //    string formatoCodigo = "Código do Doc de Entrada.";
        //    string formatoPrefixo = "Prefixo: 426 - Para Outras Entradas YAMAHA.";
        //    string formatoSufixoYAL = "Sufixo: YAL - Para YAMAHA.";
        //    string formatoSufixoMAL = "Sufixo: MAL - Para MERCURY.";
        //    string formatoSufixoZFM = "Sufixo: ZFM - Para todos Fornecedores.";
        //    string formatoSufixoZFMMot = "Sufixo: ZFM - Para Motores.";
        //    string formatoSufixoNAC = "Sufixo: NAC - Para Motores.";

        //    string codcalcRevProdNac = "00001"; string calcRevProdNac = "REVENDA PROD NACIONAL";
        //    string codcalcRevProdImp = "00002"; string calcRevProdImp = "REVENDA PROD IMP ZFM";
        //    string codRevProdSubTrib = "00003"; string calcRevProdSubTrib = "REVENDA PROD NAC/IMP/NACIONALIZADO COM ST";
        //    string codRevProdImpNac = "00008"; string calcRevProdImpNac = "REVENDA DE PROD IMP NACIONALIZADO";
        //    string codRevendaProdPbb = "0000?"; string calcRevProdPbb = "REVENDA DE PRODUTO COM PPB";
        //    string codInsumos = "00010"; string calcInsumos = "INSUMOS";


        //    txtCodClassFiscal.Text = txtCodNCM.Text; txtNomeClassFiscal.Text = txtNomeNCM.Text;

        //    #region Revenda
        //    if (radRevenda.Checked)
        //    {
        //        if (radForBrasileiro.Checked)
        //        {
        //            if (radOrigemNac.Checked)
        //            {
        //                if (chkPecasMot.Checked)
        //                {

        //                }
        //                else if (chkMotores.Checked)
        //                {

        //                }
        //                else
        //                {

        //                    if (picSubTribOK.Visible)
        //                    {

        //                    }
        //                    if (picAutopecasOK.Visible)
        //                    {

        //                    }
        //                    if (picSemSimilarOK.Visible)
        //                    {

        //                    }

        //                }

        //            }
        //            else if (radOrigemImp.Checked)
        //            {
        //                if (chkPecasMot.Checked)
        //                {

        //                }
        //                if (chkMotores.Checked)
        //                {

        //                }
        //            }

        //        }
        //        else if (radForEstrangeiro.Checked)
        //        {
        //            if (chkPecasMot.Checked)
        //            {

        //            }
        //            if (chkMotores.Checked)
        //            {

        //            }
        //        }

        //        else if (radForZFM.Checked)
        //        {
        //            if (radOrigemNac.Checked)
        //            {
        //                if (chkPecasMot.Checked)
        //                {

        //                }
        //                if (chkMotores.Checked)
        //                {

        //                }
        //            }
        //            else if (radOrigemImp.Checked)
        //            {
        //                if (chkPecasMot.Checked)
        //                {

        //                }
        //                else if (chkMotores.Checked)
        //                {

        //                }
        //                else
        //                {

        //                }
        //            }
        //        }
        //    }
        //    #endregion

        //    #region Materia Prima
        //    else if (radMatPrima.Checked)
        //    {
        //        if (radForBrasileiro.Checked)
        //        {

        //        }
        //        else if (radForEstrangeiro.Checked)
        //        {

        //        }
        //        else if (radForZFM.Checked)
        //        {

        //        }


        //    }

        //    #endregion

        //    #region Insumos
        //    else if (radInsumos.Checked)
        //    {
        //        if (radForBrasileiro.Checked)
        //        {

        //        }
        //        else if (radForEstrangeiro.Checked)
        //        {

        //        }
        //        else if (radForZFM.Checked)
        //        {

        //        }

        //    }
        //    #endregion

        //    txtCaracCod1.Text = "013"; txtCaracNome1.Text = "TRIBUTADO";
        //    txtCaracCod2.Text = "010"; txtCaracNome2.Text = "ALIQUOTA BÁSICA";


        //    txtPisCstEntrada.Text = "70";
        //    txtCofinsCstEntrada.Text = "70";

        //    if (radForBrasileiro.Checked || radForZFM.Checked)
        //    {
        //        if (picAutopecasOK.Visible == true)
        //        {
        //            txtAliquotaPisPerc.Text = "0,00"; txtPisCstSaida.Text = "04";
        //            txtAliquotaCofinsPerc.Text = "0,00"; txtCofinsCstSaida.Text = "04";

        //            txtCaracCod2.Text = "009"; txtCaracNome2.Text = "AUTOPEÇAS";
        //        }

        //        else
        //        {
        //            txtAliquotaPisPerc.Text = "0,65"; txtPisCstSaida.Text = "01";
        //            txtAliquotaCofinsPerc.Text = "3,00"; txtCofinsCstSaida.Text = "01";
        //        }
        //    }

        //    else if (radForEstrangeiro.Checked)
        //    {
        //        if (picAutopecasOK.Visible == true)
        //        {
        //            txtAliquotaPisPerc.Text = "2,30"; txtPisCstSaida.Text = "02";
        //            txtAliquotaCofinsPerc.Text = "10,80"; txtCofinsCstSaida.Text = "02";

        //            txtCaracCod2.Text = "023"; txtCaracNome2.Text = "AUTOPEÇAS IMPORTADAS ZFM";

        //        }
        //        else
        //        {
        //            txtAliquotaPisPerc.Text = "0,65"; txtPisCstSaida.Text = "01";
        //            txtAliquotaCofinsPerc.Text = "3,00"; txtCofinsCstSaida.Text = "01";

        //        }
        //    }

        //    if (radRevenda.Checked)
        //    {


        //        txtComCodSetor1.Text = "00001"; txtComSetor1.Text = "MOTORES";

        //        if (chkMotores.Checked == false)
        //        {
        //            if (chkPecasMot.Checked == false)
        //            {
        //                txtComCodEmpresa.Text = "00001"; txtComNomeEmpresa.Text = "ALEGRA IND E COM LTDA (MATRIZ)";
        //                txtComVenda.Text = "S";
        //                txtComCompra.Text = "S";
        //                txtIndCodEmpresa.Text = "00002"; txtIndNomeEmpresa.Text = "ALEGRA IND E COM LTDA (IND)";
        //                txtIndVenda.Text = "N";
        //                txtIndCompra.Text = "S";
        //            }

        //            txtComCodSetor1.Text = "00001"; txtComSetor1.Text = "LOJA";
        //            txtComCodSetor2.Text = "00002"; txtComSetor2.Text = "DEPÓSITO";
        //            txtComCodSetor3.Text = "00003"; txtComSetor3.Text = "MARINER";
        //            txtComCodSetor4.Text = "00004"; txtComSetor4.Text = "SERVIÇOS";
        //            txtComCodSetor5.Text = "00005"; txtComSetor5.Text = "OBRAS";
        //        }

        //        txtComCodEmpresa.Text = "00001"; txtComNomeEmpresa.Text = "ALEGRA IND E COM LTDA (MATRIZ)";
        //        txtComVenda.Text = "S";
        //        txtComCompra.Text = "S";

        //        chkRepasse.Checked = true;
        //        radFaturamento.Checked = true;
        //        chkCompoBCdaCsll.Checked = true;
        //        chkCalcCOFINS.Checked = true;
        //        chkCalcPIS.Checked = true;

        //        txtCaracCod4.Text = "018"; txtCaracNome4.Text = " BLOQUEIO NEGATIVO";

        //        if (radForBrasileiro.Checked)
        //        {
        //            if (radOrigemNac.Checked)
        //            {
        //                txtCodCalcICMS.Text = codcalcRevProdNac; txtNomeCalcICMS.Text = calcRevProdNac;

        //                if (picSubTribOK.Visible == true)
        //                {
        //                    txtCodCalcICMS.Text = codRevProdSubTrib;
        //                    txtNomeCalcICMS.Text = calcRevProdSubTrib;
        //                }

        //                if (chkPecasMot.Checked)
        //                {
        //                    txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoPrefixo;
        //                    txtFormatoCod2.Text = formatoCodigo;
        //                    txtCodCalcICMS.Text = codcalcRevProdNac;
        //                    txtNomeCalcICMS.Text = calcRevProdNac;
        //                    txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Subst Tributária.";
        //                }

        //                radOrigem0.Checked = true;

        //            }

        //            else if (radOrigemImp.Checked)
        //            {
        //                txtCodCalcICMS.Text = codRevProdImpNac; txtNomeCalcICMS.Text = calcRevProdImpNac;

        //                if (chkPecasMot.Checked)
        //                {
        //                    txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoPrefixo;
        //                    txtFormatoCod2.Text = formatoCodigo;
        //                    txtCodCalcICMS.Text = codRevProdImpNac;
        //                    txtNomeCalcICMS.Text = calcRevProdImpNac;
        //                    txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Subs. Tributária";
        //                }

        //                if (picSemSimilarOK.Visible == true)
        //                {
        //                    radOrigem7.Checked = true;
        //                }
        //                else
        //                {
        //                    radOrigem2.Checked = true;
        //                }
        //            }
        //        }

        //        if (radForEstrangeiro.Checked)
        //        {
        //            txtCodCalcICMS.Text = codcalcRevProdImp; txtNomeCalcICMS.Text = calcRevProdImp;

        //            if (picSubTribOK.Visible == true)
        //            {
        //                txtCodCalcICMS.Text = codRevProdSubTrib;
        //                txtNomeCalcICMS.Text = calcRevProdSubTrib;
        //            }

        //            if (chkPecasMot.Checked)
        //            {
        //                txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoZFM;
        //                txtFormatoCod2.Text = formatoCodigo;
        //                txtCodCalcICMS.Text = codcalcRevProdImp;
        //                txtNomeCalcICMS.Text = calcRevProdImp;
        //                txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Autopeças.";
        //            }

        //            if (picSemSimilarOK.Visible == true)
        //            {
        //                radOrigem6.Checked = true;
        //            }
        //            else
        //            {
        //                radOrigem1.Checked = true;
        //            }
        //        }

        //        if (radForZFM.Checked)
        //        {
        //            if (radOrigemNac.Checked)
        //            {
        //                txtCodCalcICMS.Text = codcalcRevProdNac; txtNomeCalcICMS.Text = calcRevProdNac;
        //                txtFormatoCod1.Text = formatoCodigo;
        //                txtFormatoCod2.Text = formatoCodigo;
        //                radOrigem0.Checked = true;

        //                if (chkMotores.Checked)
        //                {
        //                    txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoNAC;
        //                    radOrigem4.Checked = true;
        //                    txtCodCalcICMS.Text = codRevendaProdPbb; txtNomeCalcICMS.Text = calcRevProdPbb;
        //                }


        //                if (picSubTribOK.Visible == true)
        //                {
        //                    txtCodCalcICMS.Text = codRevProdSubTrib;
        //                    txtNomeCalcICMS.Text = calcRevProdSubTrib;
        //                }

        //                if (chkPecasMot.Checked)
        //                {
        //                    txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoYAL + Environment.NewLine + formatoSufixoMAL;
        //                    txtFormatoCod2.Text = formatoCodigo;
        //                    txtCodCalcICMS.Text = codcalcRevProdNac;
        //                    txtNomeCalcICMS.Text = calcRevProdNac;
        //                    txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Autopeças.";
        //                }


        //            }

        //            if (radOrigemImp.Checked)
        //            {
        //                txtCodCalcICMS.Text = codRevProdImpNac; txtNomeCalcICMS.Text = calcRevProdImpNac;
        //                txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoZFMMot;
        //                txtFormatoCod2.Text = formatoCodigo;

        //                if (picSubTribOK.Visible == true)
        //                {
        //                    txtCodCalcICMS.Text = codRevProdSubTrib;
        //                    txtNomeCalcICMS.Text = calcRevProdSubTrib;
        //                }

        //                if (chkPecasMot.Checked)
        //                {
        //                    txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoYAL + Environment.NewLine + formatoSufixoMAL;
        //                    txtFormatoCod2.Text = formatoCodigo;
        //                    txtCodCalcICMS.Text = codRevProdImpNac;
        //                    txtNomeCalcICMS.Text = calcRevProdImpNac;
        //                    txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Autopeças.";
        //                }

        //                if (picSemSimilarOK.Visible == true)
        //                {
        //                    radOrigem7.Checked = true;
        //                }
        //                else
        //                {
        //                    radOrigem2.Checked = true;
        //                }
        //            }
        //        }
        //    }

        //    else if (radMatPrima.Checked || radInsumos.Checked)
        //    {
        //        txtCodProd1.Text = "000005"; txtNomeCodProd1.Text = "FORNECEDOR"; txtFormatoCod1.Text = formatoCodigo;

        //        txtCodCalcICMS.Text = codInsumos; txtNomeCalcICMS.Text = calcInsumos;

        //        txtIndCodEmpresa.Text = "00002"; txtIndNomeEmpresa.Text = "ALEGRA IND E COM LTDA (IND)";
        //        txtIndVenda.Text = "N";
        //        txtIndCompra.Text = "S";

        //        chkRepasse.Checked = false;
        //        radFaturamento.Checked = false;
        //        radOrigem4.Checked = true;

        //        txtIndCodSetor1.Text = "00001"; txtIndSetor1.Text = "INDUSTRIAL";
        //    }

        //    if (picSubTribOK.Visible == true)
        //    {
        //        chkTribEspecifica.Checked = true;
        //        txtCaracCod1.Text = "012"; txtCaracNome1.Text = "COM SUBST. TRiBUTARIA";
        //        txtCodCalcICMS.Text = codRevProdSubTrib; txtNomeCalcICMS.Text = calcRevProdSubTrib;

        //        if (radRevenda.Checked)
        //        {
        //            if (chkPecasMot.Checked || chkMotores.Checked)
        //            {
        //                txtCodCalcICMS.Text = codRevProdImpNac; txtNomeCalcICMS.Text = calcRevProdImpNac;

        //                if (radForEstrangeiro.Checked)
        //                {
        //                    txtCodCalcICMS.Text = codcalcRevProdImp; txtNomeCalcICMS.Text = calcRevProdImp;
        //                }

        //                txtCaracCod1.Text = "013"; txtCaracNome1.Text = "TRIBUTADO";
        //                txtComCfop1.Text = "5.102"; txtComTpMov1.Text = "Venda"; txtComCfopEqui1.Text = "5.405";
        //                txtComCfop2.Text = "5.152"; txtComTpMov2.Text = "Tranferência"; txtComCfopEqui2.Text = "5.409"; txtComTransDev2.Text = "Saida";
        //                txtComCfop3.Text = "1.102"; txtComTpMov3.Text = "Compra"; txtComCfopEqui3.Text = "1.403";
        //                txtComCfop4.Text = "2.102"; txtComTpMov4.Text = "Compra"; txtComCfopEqui4.Text = "2.403";
        //                txtComCfop5.Text = "1.202"; txtComTpMov5.Text = "Devolução"; txtComCfopEqui5.Text = "1.411"; ;
        //                txtComCfop6.Text = "2.202"; txtComTpMov6.Text = "Devolução"; txtComCfopEqui6.Text = "2.411"; txtComTransDev6.Text = "Venda";
        //            }
        //            else
        //            {
        //                txtComCfop1.Text = "5.102"; txtComTpMov1.Text = "Venda"; txtComCfopEqui1.Text = "5.405";
        //                txtComCfop2.Text = "5.152"; txtComTpMov2.Text = "Tranferência"; txtComCfopEqui2.Text = "5.409"; txtComTransDev2.Text = "Saida";
        //                txtComCfop3.Text = "1.102"; txtComTpMov3.Text = "Compra"; txtComCfopEqui3.Text = "1.403";
        //                txtComCfop4.Text = "2.102"; txtComTpMov4.Text = "Compra"; txtComCfopEqui4.Text = "2.403";
        //                txtComCfop5.Text = "1.202"; txtComTpMov5.Text = "Devolução"; txtComCfopEqui5.Text = "1.411"; ;
        //                txtComCfop6.Text = "2.202"; txtComTpMov6.Text = "Devolução"; txtComCfopEqui6.Text = "2.411"; txtComTransDev6.Text = "Venda";

        //                txtIndCfop1.Text = "1.151"; txtIndTpMov1.Text = "Entrada"; txtIndCfopEqui1.Text = "1.408";
        //                txtIndCfop2.Text = "1.101"; txtIndTpMov2.Text = "Compra"; txtIndCfopEqui2.Text = "1.401";
        //                txtIndCfop3.Text = "2.101"; txtIndTpMov3.Text = "Compra"; txtIndCfopEqui3.Text = "2.401";
        //            }
        //        }
        //        else
        //        {
        //            txtIndCfop1.Text = "1.151"; txtIndTpMov1.Text = "Entrada"; txtIndCfopEqui1.Text = "1.408";
        //            txtIndCfop2.Text = "1.101"; txtIndTpMov2.Text = "Compra"; txtIndCfopEqui2.Text = "1.401";
        //            txtIndCfop3.Text = "2.101"; txtIndTpMov3.Text = "Compra"; txtIndCfopEqui3.Text = "2.401";

        //        }
        //    }
        //}
    }
}
