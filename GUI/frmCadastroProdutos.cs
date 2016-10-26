using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Modelo;
using BLL;
using DAL;
using System.Data.SqlServerCe;

namespace GUI
{
    public partial class frmCadastroProdutos : Form
    {
        Design modelo = new Design();

        public frmCadastroProdutos()
        {
            InitializeComponent();

            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                RadioButton rdb = (RadioButton)groupBox1.Controls[i];
                rdb.CheckedChanged += new EventHandler(groupBox1_CheckedChanged);
            }

            FillCbo();
        }

        private void groupBox1_CheckedChanged(object sender, EventArgs e)
        {
            FillCbo();
        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            ApagaPics();
            mtxtCest.Mask = "00,000,00";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmLocalizarNCM frm = new frmLocalizarNCM();
            frm.ShowDialog();
            if (frm.codigo != 0)
            {
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLNCM bll = new BLLNCM(dalconexao);
                ModeloNCM modelo = bll.CarregaModeloNCM(frm.codigo);
                txtCodNCM.Text = modelo.CodNCM;
                txtNomeNCM.Text = modelo.NomeNCM;
                picSubTribOK.Visible = Convert.ToBoolean(modelo.SitST);
                picAutopecasOK.Visible = Convert.ToBoolean(modelo.SitAuto);
                picSemSimilarOK.Visible = Convert.ToBoolean(modelo.SitSemSimilar);
                mtxtCest.Text = modelo.Cest;
            }

            frm.Dispose();
        }

        private void radRevenda_Click(object sender, EventArgs e)
        {
            chkPecasMot.Visible = true;
            chkMotores.Visible = true;
            chkProdutoPPB.Visible = false;
        }

        private void radMatPrima_Click(object sender, EventArgs e)
        {
            chkPecasMot.Visible = false;
            chkMotores.Visible = false;
            chkProdutoPPB.Visible = true;
            chkProdutoPPB.Enabled = false;
        }

        private void radInsumos_Click(object sender, EventArgs e)
        {
            chkPecasMot.Visible = false;
            chkMotores.Visible = false;
            chkProdutoPPB.Visible = true;
            chkProdutoPPB.Enabled = false;
        }

        private void radForEstrangeiro_Click(object sender, EventArgs e)
        {
            radOrigemNac.Checked = false;
            radOrigemNac.Enabled = false;
            radOrigemImp.Checked = true;
            chkProdutoPPB.Enabled = false;
        }

        private void radForBrasileiro_Click(object sender, EventArgs e)
        {
            radOrigemNac.Enabled = true;
            chkProdutoPPB.Enabled = false;
        }

        private void radForZFM_Click(object sender, EventArgs e)
        {
            radOrigemNac.Enabled = true;
            chkProdutoPPB.Enabled = true;

        }

        private void radOrigemImp_Click(object sender, EventArgs e)
        {
            chkProdutoPPB.Checked = false;
        }

        private void chkProdutoPPB_Click(object sender, EventArgs e)
        {
            radOrigemImp.Checked = false;
            radOrigemNac.Checked = true;
        }

        private void txtCodNCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnLocalizar_Click(sender, e);
            }
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodNCM.Text == "")
                {
                    throw new Exception("O Código da NCM é Obrigatório!");
                }

                if (cboGrupo.Text == "")
                {
                    throw new Exception("O Grupo é Obrigatório!");
                }

                if (chkPecasMot.Checked && chkMotores.Checked)
                {
                    throw new Exception("Verifique o tipo do Produto");
                   
                }
                if (chkMotores.Checked && picSubTribOK.Visible || chkMotores.Checked && picAutopecasOK.Visible)
                {
                    throw new Exception("Verifique a NCM do Produto e o Tipo!\nMotores não tem Subs. Tributária");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
           
            modelo.LimparTela(tabPrincipal);
            AvaliarDadosProdutos();
      
        }

        private void ApagaPics()
        {
            picSubTribOK.Visible = false;
            picAutopecasOK.Visible = false;
            picSemSimilarOK.Visible = false;
        }

        private int GetTipo()
        {
            Finalidade fin = Finalidade.None;

            if (radRevenda.Checked) { fin = Finalidade.Revenda; }
            if (radMatPrima.Checked) { fin = Finalidade.MatPrima; }
            if (radInsumos.Checked) { fin = Finalidade.Insumos; }

            return Convert.ToInt32(fin);
        }

        private DataTable GetGrupo()
        {

            DALConexao dalConexao = new DALConexao(DadosDeConexao.strConexao);
            DataTable getGrupo = new DataTable("Grupo");
            SqlCeCommand sqlCmd = new SqlCeCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "SELECT NomeGrupo, GrupoID FROM Grupos WHERE TipoID = @codigo";
            sqlCmd.Parameters.AddWithValue("@codigo", GetTipo());
            dalConexao.Conectar();
            getGrupo.Load(sqlCmd.ExecuteReader());
            dalConexao.Desconectar();
            return getGrupo;
        }

        private void FillCbo()
        {

            cboGrupo.ValueMember = "GrupoID";
            cboGrupo.DisplayMember = "NomeGrupo";
            cboGrupo.DataSource = GetGrupo();
            cboGrupo.Update();
            cboGrupo.SelectedIndex = -1;

        }

        private void AvaliarDadosProdutos()
        {
            //Verifica a Finalidade do Produto
            string formatoCodigo = "Código do Doc de Entrada.";
            string formatoPrefixo = "Prefixo: 426 - Para Outras Entradas YAMAHA.";
            string formatoSufixoYAL = "Sufixo: YAL - Para YAMAHA.";
            string formatoSufixoMAL = "Sufixo: MAL - Para MERCURY.";
            string formatoSufixoZFM = "Sufixo: ZFM - Para todos Fornecedores.";
            string formatoSufixoZFMMot = "Sufixo: ZFM - Para Motores.";
            string formatoSufixoNAC = "Sufixo: NAC - Para Motores.";

            string codcalcRevProdNac = "00001"; string calcRevProdNac = "REVENDA PROD NACIONAL";
            string codcalcRevProdImp = "00002"; string calcRevProdImp = "REVENDA PROD IMP ZFM";
            string codRevProdSubTrib = "00003"; string calcRevProdSubTrib = "REVENDA PROD NAC/IMP/NACIONALIZADO COM ST";
            string codRevProdImpNac = "00008"; string calcRevProdImpNac = "REVENDA DE PROD IMP NACIONALIZADO";
            string codRevendaProdPbb = "0000?"; string calcRevProdPbb = "REVENDA DE PRODUTO COM PPB";
            string codInsumos = "00010"; string calcInsumos = "INSUMOS";


            txtCodClassFiscal.Text = txtCodNCM.Text; txtNomeClassFiscal.Text = txtNomeNCM.Text;

            #region Revenda
            if (radRevenda.Checked)
            {
                chkPecasMot.Enabled = true;
                chkMotores.Enabled = true;

                txtCodProd1.Text = "000001"; txtNomeCodProd1.Text = "LOJA"; txtFormatoCod1.Text = formatoCodigo;
                txtCodProd2.Text = "000005"; txtNomeCodProd2.Text = "FORNECEDOR"; txtFormatoCod2.Text = formatoCodigo;

                chkRepasse.Checked = true;
                radFaturamento.Checked = true;

                chkCompoBCdaCsll.Checked = true;
                chkCalcCOFINS.Checked = true;
                chkCalcPIS.Checked = true;

                txtPisCstEntrada.Text = "70";
                txtCofinsCstEntrada.Text = "70";

                txtComCodEmpresa.Text = "00001"; txtComNomeEmpresa.Text = "ALEGRA IND E COM LTDA (MATRIZ)";
                txtComVenda.Text = "S";
                txtComCompra.Text = "S";
                txtIndCodEmpresa.Text = "00002"; txtIndNomeEmpresa.Text = "ALEGRA IND E COM LTDA (IND)";
                txtIndVenda.Text = "N";
                txtIndCompra.Text = "S";

                txtComCodSetor1.Text = "00001"; txtComSetor1.Text = "LOJA";
                txtComCodSetor2.Text = "00002"; txtComSetor2.Text = "DEPÓSITO";
                txtComCodSetor3.Text = "00014"; txtComSetor4.Text = "OBRAS";
                txtComCodSetor4.Text = "00015"; txtComSetor3.Text = "MARINER";

                txtCaracCod1.Text = "013"; txtCaracNome1.Text = "TRIBUTADO";
                txtCaracCod2.Text = "010"; txtCaracNome2.Text = "ALIQUOTA BÁSICA";
                txtCaracCod4.Text = "018"; txtCaracNome4.Text = " BLOQUEIO NEGATIVO";

                #region FornBrasileiro
                if (radForBrasileiro.Checked)
                {
                    txtAliquotaPisPerc.Text = "0,65"; txtPisCstSaida.Text = "01";
                    txtAliquotaCofinsPerc.Text = "3,00"; txtCofinsCstSaida.Text = "01";

                    #region FornBraileiro Origem Nac
                    if (radOrigemNac.Checked)
                    {
                        radOrigem0.Checked = true;

                        txtCodCalcICMS.Text = codcalcRevProdNac; txtNomeCalcICMS.Text = calcRevProdNac;

                        if (picSubTribOK.Visible)
                        {
                            chkTribEspecifica.Checked = true;
                            txtCodCalcICMS.Text = codRevProdSubTrib; txtNomeCalcICMS.Text = calcRevProdSubTrib;

                            txtCaracCod1.Text = "012"; txtCaracNome1.Text = "COM SUBST. TRiBUTARIA";

                            txtComCfop1.Text = "5.102"; txtComTpMov1.Text = "Venda"; txtComCfopEqui1.Text = "5.405";
                            txtComCfop3.Text = "1.102"; txtComTpMov3.Text = "Compra"; txtComCfopEqui3.Text = "1.403";
                            txtComCfop2.Text = "5.152"; txtComTpMov2.Text = "Tranferência"; txtComCfopEqui2.Text = "5.409"; txtComTransDev2.Text = "Saida";
                            txtComCfop4.Text = "2.102"; txtComTpMov4.Text = "Compra"; txtComCfopEqui4.Text = "2.403";
                            txtComCfop5.Text = "1.202"; txtComTpMov5.Text = "Devolução"; txtComCfopEqui5.Text = "1.411"; ;
                            txtComCfop6.Text = "2.202"; txtComTpMov6.Text = "Devolução"; txtComCfopEqui6.Text = "2.411"; txtComTransDev6.Text = "Venda";

                            txtIndCfop1.Text = "1.151"; txtIndTpMov1.Text = "Entrada"; txtIndCfopEqui1.Text = "1.408";
                            txtIndCfop2.Text = "1.101"; txtIndTpMov2.Text = "Compra"; txtIndCfopEqui2.Text = "1.401";
                            txtIndCfop3.Text = "2.101"; txtIndTpMov3.Text = "Compra"; txtIndCfopEqui3.Text = "2.401";
                        }

                        if (picAutopecasOK.Visible)
                        {
                            txtAliquotaPisPerc.Text = "0,00"; txtPisCstSaida.Text = "04";
                            txtAliquotaCofinsPerc.Text = "0,00"; txtCofinsCstSaida.Text = "04";

                            txtCaracCod2.Text = "009"; txtCaracNome2.Text = "AUTOPEÇAS";
                        }

                        if (picSemSimilarOK.Visible)
                        {
                            txtCaracCod3.Text = "016"; txtCaracNome3.Text = "PROD CONSTA LISTA CAMEX SEM SIMILAR NAC";
                        }

                        if (chkPecasMot.Checked)
                        {
                            chkTribEspecifica.Checked = false;

                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoPrefixo;
                            txtCodCalcICMS.Text = codcalcRevProdNac;
                            txtNomeCalcICMS.Text = calcRevProdNac;
                            if (picSubTribOK.Visible)
                            {
                                txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Subst Tributária.";
                            }

                            txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                            txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                            txtIndVenda.Text = "";
                            txtIndCompra.Text = "";

                            txtCaracCod1.Text = "013"; txtCaracNome1.Text = "TRIBUTADO";

                            txtComCfop1.Text = ""; txtComTpMov1.Text = ""; txtComCfopEqui1.Text = "";
                            txtComCfop3.Text = ""; txtComTpMov3.Text = ""; txtComCfopEqui3.Text = "";
                            txtComCfop2.Text = ""; txtComTpMov2.Text = ""; txtComCfopEqui2.Text = ""; txtComTransDev2.Text = "";
                            txtComCfop4.Text = ""; txtComTpMov4.Text = ""; txtComCfopEqui4.Text = "";
                            txtComCfop5.Text = ""; txtComTpMov5.Text = ""; txtComCfopEqui5.Text = ""; ;
                            txtComCfop6.Text = ""; txtComTpMov6.Text = ""; txtComCfopEqui6.Text = ""; txtComTransDev6.Text = "";

                            txtIndCfop1.Text = ""; txtIndTpMov1.Text = ""; txtIndCfopEqui1.Text = "";
                            txtIndCfop2.Text = ""; txtIndTpMov2.Text = ""; txtIndCfopEqui2.Text = "";
                            txtIndCfop3.Text = ""; txtIndTpMov3.Text = ""; txtIndCfopEqui3.Text = "";
                        }
                        else if (chkMotores.Checked)
                        {
                            txtComCodSetor1.Text = "00008"; txtComSetor1.Text = "MOTORES";
                            txtComCodSetor2.Text = ""; txtComSetor2.Text = "";
                            txtComCodSetor3.Text = ""; txtComSetor3.Text = "";
                            txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                            txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                            txtIndVenda.Text = "";
                            txtIndCompra.Text = "";
                        }
                    }
                    #endregion

                    #region FornBrasileiro Origem Imp
                    else if (radOrigemImp.Checked)
                    {
                        radOrigem2.Checked = true;

                        txtAliquotaPisPerc.Text = "0,65"; txtPisCstSaida.Text = "01";
                        txtAliquotaCofinsPerc.Text = "3,00"; txtCofinsCstSaida.Text = "01";

                        txtCodCalcICMS.Text = codRevProdImpNac; txtNomeCalcICMS.Text = calcRevProdImpNac;

                        if (picSubTribOK.Visible)
                        {
                            chkTribEspecifica.Checked = true;
                            txtCodCalcICMS.Text = codRevProdSubTrib; txtNomeCalcICMS.Text = calcRevProdSubTrib;

                            txtCaracCod1.Text = "012"; txtCaracNome1.Text = "COM SUBST. TRiBUTARIA";

                            txtComCfop1.Text = "5.102"; txtComTpMov1.Text = "Venda"; txtComCfopEqui1.Text = "5.405";
                            txtComCfop3.Text = "1.102"; txtComTpMov3.Text = "Compra"; txtComCfopEqui3.Text = "1.403";
                            txtComCfop2.Text = "5.152"; txtComTpMov2.Text = "Tranferência"; txtComCfopEqui2.Text = "5.409"; txtComTransDev2.Text = "Saida";
                            txtComCfop4.Text = "2.102"; txtComTpMov4.Text = "Compra"; txtComCfopEqui4.Text = "2.403";
                            txtComCfop5.Text = "1.202"; txtComTpMov5.Text = "Devolução"; txtComCfopEqui5.Text = "1.411"; ;
                            txtComCfop6.Text = "2.202"; txtComTpMov6.Text = "Devolução"; txtComCfopEqui6.Text = "2.411"; txtComTransDev6.Text = "Venda";

                            txtIndCfop1.Text = "1.151"; txtIndTpMov1.Text = "Entrada"; txtIndCfopEqui1.Text = "1.408";
                            txtIndCfop2.Text = "1.101"; txtIndTpMov2.Text = "Compra"; txtIndCfopEqui2.Text = "1.401";
                            txtIndCfop3.Text = "2.101"; txtIndTpMov3.Text = "Compra"; txtIndCfopEqui3.Text = "2.401";
                        }
                        if (picAutopecasOK.Visible)
                        {
                            txtAliquotaPisPerc.Text = "0,00"; txtPisCstSaida.Text = "04";
                            txtAliquotaCofinsPerc.Text = "0,00"; txtCofinsCstSaida.Text = "04";

                            txtCaracCod2.Text = "009"; txtCaracNome2.Text = "AUTOPEÇAS";
                        }
                        if (picSemSimilarOK.Visible)
                        {
                            radOrigem7.Checked = true;
                            radOrigem2.Checked = false;

                            txtCaracCod3.Text = "016"; txtCaracNome3.Text = "PROD CONSTA LISTA CAMEX SEM SIMILAR NAC";
                        }

                        if (chkPecasMot.Checked)
                        {
                            chkTribEspecifica.Checked = false;

                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoPrefixo;
                            txtCodCalcICMS.Text = codRevProdImpNac;
                            txtNomeCalcICMS.Text = calcRevProdImpNac;

                            if (picSubTribOK.Visible)
                            {
                                txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Subst Tributária.";
                            }

                            txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                            txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                            txtIndVenda.Text = "";
                            txtIndCompra.Text = "";

                            txtCaracCod1.Text = "013"; txtCaracNome1.Text = "TRIBUTADO";

                            txtComCfop1.Text = ""; txtComTpMov1.Text = ""; txtComCfopEqui1.Text = "";
                            txtComCfop3.Text = ""; txtComTpMov3.Text = ""; txtComCfopEqui3.Text = "";
                            txtComCfop2.Text = ""; txtComTpMov2.Text = ""; txtComCfopEqui2.Text = ""; txtComTransDev2.Text = "";
                            txtComCfop4.Text = ""; txtComTpMov4.Text = ""; txtComCfopEqui4.Text = "";
                            txtComCfop5.Text = ""; txtComTpMov5.Text = ""; txtComCfopEqui5.Text = ""; ;
                            txtComCfop6.Text = ""; txtComTpMov6.Text = ""; txtComCfopEqui6.Text = ""; txtComTransDev6.Text = "";

                            txtIndCfop1.Text = ""; txtIndTpMov1.Text = ""; txtIndCfopEqui1.Text = "";
                            txtIndCfop2.Text = ""; txtIndTpMov2.Text = ""; txtIndCfopEqui2.Text = "";
                            txtIndCfop3.Text = ""; txtIndTpMov3.Text = ""; txtIndCfopEqui3.Text = "";
                        }
                        if (chkMotores.Checked)
                        {
                            txtComCodSetor1.Text = "00008"; txtComSetor1.Text = "MOTORES";
                            txtComCodSetor2.Text = ""; txtComSetor2.Text = "";
                            txtComCodSetor3.Text = ""; txtComSetor3.Text = "";
                            txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                            txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                            txtIndVenda.Text = "";
                            txtIndCompra.Text = "";
                        }
                    }
                    #endregion
                }
                #endregion

                #region FornEstrangeiro
                else if (radForEstrangeiro.Checked)
                {
                    radOrigem1.Checked = true;

                    txtAliquotaPisPerc.Text = "0,65"; txtPisCstSaida.Text = "01";
                    txtAliquotaCofinsPerc.Text = "3,00"; txtCofinsCstSaida.Text = "01";

                    txtCodCalcICMS.Text = codcalcRevProdImp; txtNomeCalcICMS.Text = calcRevProdImp;

                    if (picSubTribOK.Visible)
                    {
                        chkTribEspecifica.Checked = true;

                        txtCodCalcICMS.Text = codRevProdSubTrib;
                        txtNomeCalcICMS.Text = calcRevProdSubTrib;

                        txtCaracCod1.Text = "012"; txtCaracNome1.Text = "COM SUBST. TRiBUTARIA";

                        txtComCfop1.Text = "5.102"; txtComTpMov1.Text = "Venda"; txtComCfopEqui1.Text = "5.405";
                        txtComCfop3.Text = "1.102"; txtComTpMov3.Text = "Compra"; txtComCfopEqui3.Text = "1.403";
                        txtComCfop2.Text = "5.152"; txtComTpMov2.Text = "Tranferência"; txtComCfopEqui2.Text = "5.409"; txtComTransDev2.Text = "Saida";
                        txtComCfop4.Text = "2.102"; txtComTpMov4.Text = "Compra"; txtComCfopEqui4.Text = "2.403";
                        txtComCfop5.Text = "1.202"; txtComTpMov5.Text = "Devolução"; txtComCfopEqui5.Text = "1.411"; ;
                        txtComCfop6.Text = "2.202"; txtComTpMov6.Text = "Devolução"; txtComCfopEqui6.Text = "2.411"; txtComTransDev6.Text = "Venda";

                        txtIndCfop1.Text = "1.151"; txtIndTpMov1.Text = "Entrada"; txtIndCfopEqui1.Text = "1.408";
                        txtIndCfop2.Text = "1.101"; txtIndTpMov2.Text = "Compra"; txtIndCfopEqui2.Text = "1.401";
                        txtIndCfop3.Text = "2.101"; txtIndTpMov3.Text = "Compra"; txtIndCfopEqui3.Text = "2.401";
                    }

                    if (picAutopecasOK.Visible)
                    {
                        txtAliquotaPisPerc.Text = "2,30"; txtPisCstSaida.Text = "02";
                        txtAliquotaCofinsPerc.Text = "10,80"; txtCofinsCstSaida.Text = "02";

                        txtCaracCod2.Text = "023"; txtCaracNome2.Text = "AUTOPEÇAS IMPORTADAS ZFM"; 
                    }
                    if (picSemSimilarOK.Visible)
                    {
                        radOrigem6.Checked = true;
                        radOrigem1.Checked = false;

                        txtCaracCod3.Text = "016"; txtCaracNome3.Text = "PROD CONSTA LISTA CAMEX SEM SIMILAR NAC";
                    }

                    if (chkPecasMot.Checked)
                    {
                        chkTribEspecifica.Checked = false;

                        txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoZFM;
                        txtCodCalcICMS.Text = codcalcRevProdImp;
                        txtNomeCalcICMS.Text = calcRevProdImp;

                        if (picSubTribOK.Visible)
                        {
                            txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Subst Tributária.";
                        }

                        txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                        txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                        txtIndVenda.Text = "";
                        txtIndCompra.Text = "";

                        txtCaracCod1.Text = "013"; txtCaracNome1.Text = "TRIBUTADO";

                        txtComCfop1.Text = ""; txtComTpMov1.Text = ""; txtComCfopEqui1.Text = "";
                        txtComCfop3.Text = ""; txtComTpMov3.Text = ""; txtComCfopEqui3.Text = "";
                        txtComCfop2.Text = ""; txtComTpMov2.Text = ""; txtComCfopEqui2.Text = ""; txtComTransDev2.Text = "";
                        txtComCfop4.Text = ""; txtComTpMov4.Text = ""; txtComCfopEqui4.Text = "";
                        txtComCfop5.Text = ""; txtComTpMov5.Text = ""; txtComCfopEqui5.Text = ""; ;
                        txtComCfop6.Text = ""; txtComTpMov6.Text = ""; txtComCfopEqui6.Text = ""; txtComTransDev6.Text = "";

                        txtIndCfop1.Text = ""; txtIndTpMov1.Text = ""; txtIndCfopEqui1.Text = "";
                        txtIndCfop2.Text = ""; txtIndTpMov2.Text = ""; txtIndCfopEqui2.Text = "";
                        txtIndCfop3.Text = ""; txtIndTpMov3.Text = ""; txtIndCfopEqui3.Text = "";
                    }
                    if (chkMotores.Checked)
                    {
                        txtComCodSetor1.Text = "00008"; txtComSetor1.Text = "MOTORES";
                        txtComCodSetor2.Text = ""; txtComSetor2.Text = "";
                        txtComCodSetor3.Text = ""; txtComSetor3.Text = "";
                        txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                        txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                        txtIndVenda.Text = "";
                        txtIndCompra.Text = "";
                    }
                }
                #endregion

                #region FornZFM
                else if (radForZFM.Checked)
                {
                    txtAliquotaPisPerc.Text = "0,65"; txtPisCstSaida.Text = "01";
                    txtAliquotaCofinsPerc.Text = "3,00"; txtCofinsCstSaida.Text = "01";
                   

                    #region ForZFM Origem Nac
                    if (radOrigemNac.Checked)
                    {
                        radOrigem0.Checked = true;

                        txtCodCalcICMS.Text = codcalcRevProdNac; txtNomeCalcICMS.Text = calcRevProdNac;

                        if (picSubTribOK.Visible)
                        {
                            chkTribEspecifica.Checked = true;

                            txtCodCalcICMS.Text = codRevProdSubTrib;
                            txtNomeCalcICMS.Text = calcRevProdSubTrib;

                            txtCaracCod1.Text = "012"; txtCaracNome1.Text = "COM SUBST. TRiBUTARIA";

                            txtComCfop1.Text = "5.102"; txtComTpMov1.Text = "Venda"; txtComCfopEqui1.Text = "5.405";
                            txtComCfop3.Text = "1.102"; txtComTpMov3.Text = "Compra"; txtComCfopEqui3.Text = "1.403";
                            txtComCfop2.Text = "5.152"; txtComTpMov2.Text = "Tranferência"; txtComCfopEqui2.Text = "5.409"; txtComTransDev2.Text = "Saida";
                            txtComCfop4.Text = "2.102"; txtComTpMov4.Text = "Compra"; txtComCfopEqui4.Text = "2.403";
                            txtComCfop5.Text = "1.202"; txtComTpMov5.Text = "Devolução"; txtComCfopEqui5.Text = "1.411"; ;
                            txtComCfop6.Text = "2.202"; txtComTpMov6.Text = "Devolução"; txtComCfopEqui6.Text = "2.411"; txtComTransDev6.Text = "Venda";

                            txtIndCfop1.Text = "1.151"; txtIndTpMov1.Text = "Entrada"; txtIndCfopEqui1.Text = "1.408";
                            txtIndCfop2.Text = "1.101"; txtIndTpMov2.Text = "Compra"; txtIndCfopEqui2.Text = "1.401";
                            txtIndCfop3.Text = "2.101"; txtIndTpMov3.Text = "Compra"; txtIndCfopEqui3.Text = "2.401";
                        }
                        if (picAutopecasOK.Visible)
                        {
                            txtAliquotaPisPerc.Text = "0,00"; txtPisCstSaida.Text = "04";
                            txtAliquotaCofinsPerc.Text = "0,00"; txtCofinsCstSaida.Text = "04";

                            txtCaracCod2.Text = "009"; txtCaracNome2.Text = "AUTOPEÇAS";
                        }
                        if (picSemSimilarOK.Visible)
                        {
                            txtCaracCod3.Text = "016"; txtCaracNome3.Text = "PROD CONSTA LISTA CAMEX SEM SIMILAR NAC";
                        }

                        if (chkPecasMot.Checked)
                        {
                            chkTribEspecifica.Checked = false;

                            txtCodCalcICMS.Text = codcalcRevProdNac;
                            txtNomeCalcICMS.Text = calcRevProdNac;

                            if (picSubTribOK.Visible)
                            {
                                txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Subst Tributária.";
                            }

                            txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                            txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                            txtIndVenda.Text = "";
                            txtIndCompra.Text = "";

                            txtCaracCod1.Text = "013"; txtCaracNome1.Text = "TRIBUTADO";

                            txtComCfop1.Text = ""; txtComTpMov1.Text = ""; txtComCfopEqui1.Text = "";
                            txtComCfop3.Text = ""; txtComTpMov3.Text = ""; txtComCfopEqui3.Text = "";
                            txtComCfop2.Text = ""; txtComTpMov2.Text = ""; txtComCfopEqui2.Text = ""; txtComTransDev2.Text = "";
                            txtComCfop4.Text = ""; txtComTpMov4.Text = ""; txtComCfopEqui4.Text = "";
                            txtComCfop5.Text = ""; txtComTpMov5.Text = ""; txtComCfopEqui5.Text = ""; ;
                            txtComCfop6.Text = ""; txtComTpMov6.Text = ""; txtComCfopEqui6.Text = ""; txtComTransDev6.Text = "";

                            txtIndCfop1.Text = ""; txtIndTpMov1.Text = ""; txtIndCfopEqui1.Text = "";
                            txtIndCfop2.Text = ""; txtIndTpMov2.Text = ""; txtIndCfopEqui2.Text = "";
                            txtIndCfop3.Text = ""; txtIndTpMov3.Text = ""; txtIndCfopEqui3.Text = "";
                        }
                        if (chkMotores.Checked)
                        {
                            radOrigem4.Checked = true;
                            radOrigem0.Checked = false;
                            txtCodCalcICMS.Text = codRevendaProdPbb; txtNomeCalcICMS.Text = calcRevProdPbb;
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoNAC;

                            txtComCodSetor1.Text = "00008"; txtComSetor1.Text = "MOTORES";
                            txtComCodSetor2.Text = ""; txtComSetor2.Text = "";
                            txtComCodSetor3.Text = ""; txtComSetor3.Text = "";
                            txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                            txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                            txtIndVenda.Text = "";
                            txtIndCompra.Text = "";
                        }
                        
                    }
                    #endregion

                    #region ForZFM Origem Imp
                    else if (radOrigemImp.Checked)
                    {
                        radOrigem2.Checked = true;

                        txtCodCalcICMS.Text = codcalcRevProdImp; txtNomeCalcICMS.Text = calcRevProdImp;

                        if (picSubTribOK.Visible)
                        {
                            chkTribEspecifica.Checked = true;

                            txtCodCalcICMS.Text = codRevProdSubTrib;
                            txtNomeCalcICMS.Text = calcRevProdSubTrib;

                            txtCaracCod1.Text = "012"; txtCaracNome1.Text = "COM SUBST. TRiBUTARIA";

                            txtComCfop1.Text = "5.102"; txtComTpMov1.Text = "Venda"; txtComCfopEqui1.Text = "5.405";
                            txtComCfop3.Text = "1.102"; txtComTpMov3.Text = "Compra"; txtComCfopEqui3.Text = "1.403";
                            txtComCfop2.Text = "5.152"; txtComTpMov2.Text = "Tranferência"; txtComCfopEqui2.Text = "5.409"; txtComTransDev2.Text = "Saida";
                            txtComCfop4.Text = "2.102"; txtComTpMov4.Text = "Compra"; txtComCfopEqui4.Text = "2.403";
                            txtComCfop5.Text = "1.202"; txtComTpMov5.Text = "Devolução"; txtComCfopEqui5.Text = "1.411"; ;
                            txtComCfop6.Text = "2.202"; txtComTpMov6.Text = "Devolução"; txtComCfopEqui6.Text = "2.411"; txtComTransDev6.Text = "Venda";

                            txtIndCfop1.Text = "1.151"; txtIndTpMov1.Text = "Entrada"; txtIndCfopEqui1.Text = "1.408";
                            txtIndCfop2.Text = "1.101"; txtIndTpMov2.Text = "Compra"; txtIndCfopEqui2.Text = "1.401";
                            txtIndCfop3.Text = "2.101"; txtIndTpMov3.Text = "Compra"; txtIndCfopEqui3.Text = "2.401";
                        }
                        if (picAutopecasOK.Visible)
                        {
                            txtAliquotaPisPerc.Text = "0,00"; txtPisCstSaida.Text = "04";
                            txtAliquotaCofinsPerc.Text = "0,00"; txtCofinsCstSaida.Text = "04";

                            txtCaracCod2.Text = "009"; txtCaracNome2.Text = "AUTOPEÇAS";
                        }
                        if (picSemSimilarOK.Visible)
                        {
                            radOrigem7.Checked = true;
                            radOrigem2.Checked = false;

                            txtCaracCod3.Text = "016"; txtCaracNome3.Text = "PROD CONSTA LISTA CAMEX SEM SIMILAR NAC";
                        }

                        if (chkPecasMot.Checked)
                        {
                            chkTribEspecifica.Checked = false;

                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoYAL + Environment.NewLine + formatoSufixoMAL;
                            txtCodCalcICMS.Text = codcalcRevProdImp;
                            txtNomeCalcICMS.Text = calcRevProdImp;

                            if (picSubTribOK.Visible)
                            {
                                txtObsCalcICMS.Text = "Peças para Motores de Popa não seguem o regime de Subst Tributária.";
                            }

                            txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                            txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                            txtIndVenda.Text = "";
                            txtIndCompra.Text = "";

                            txtCaracCod1.Text = "013"; txtCaracNome1.Text = "TRIBUTADO";

                            txtComCfop1.Text = ""; txtComTpMov1.Text = ""; txtComCfopEqui1.Text = "";
                            txtComCfop3.Text = ""; txtComTpMov3.Text = ""; txtComCfopEqui3.Text = "";
                            txtComCfop2.Text = ""; txtComTpMov2.Text = ""; txtComCfopEqui2.Text = ""; txtComTransDev2.Text = "";
                            txtComCfop4.Text = ""; txtComTpMov4.Text = ""; txtComCfopEqui4.Text = "";
                            txtComCfop5.Text = ""; txtComTpMov5.Text = ""; txtComCfopEqui5.Text = ""; ;
                            txtComCfop6.Text = ""; txtComTpMov6.Text = ""; txtComCfopEqui6.Text = ""; txtComTransDev6.Text = "";

                            txtIndCfop1.Text = ""; txtIndTpMov1.Text = ""; txtIndCfopEqui1.Text = "";
                            txtIndCfop2.Text = ""; txtIndTpMov2.Text = ""; txtIndCfopEqui2.Text = "";
                            txtIndCfop3.Text = ""; txtIndTpMov3.Text = ""; txtIndCfopEqui3.Text = "";
                        }
                        else if (chkMotores.Checked)
                        {
                            txtFormatoCod1.Text = formatoCodigo + Environment.NewLine + formatoSufixoZFMMot;

                            txtComCodSetor1.Text = "00008"; txtComSetor1.Text = "MOTORES";
                            txtComCodSetor2.Text = ""; txtComSetor2.Text = "";
                            txtComCodSetor3.Text = ""; txtComSetor3.Text = "";
                            txtComCodSetor4.Text = ""; txtComSetor4.Text = "";

                            txtIndCodEmpresa.Text = ""; txtIndNomeEmpresa.Text = "";
                            txtIndVenda.Text = "";
                            txtIndCompra.Text = "";
                        }
                    }
                }
            }
            #endregion
            #endregion
            #endregion


            #region Materia Prima e Imsumos
            else if (radMatPrima.Checked || radInsumos.Checked)
            {

                txtCodProd1.Text = "000005"; txtNomeCodProd1.Text = "FORNECEDOR"; txtFormatoCod1.Text = formatoCodigo;

                chkRepasse.Checked = false;
                radFaturamento.Checked = false;

                chkCompoBCdaCsll.Checked = true;
                chkCalcCOFINS.Checked = true;
                chkCalcPIS.Checked = true;

                txtPisCstEntrada.Text = "70";
                txtCofinsCstEntrada.Text = "70";

                txtAliquotaPisPerc.Text = "0,65"; txtPisCstSaida.Text = "01";
                txtAliquotaCofinsPerc.Text = "3,00"; txtCofinsCstSaida.Text = "01";

                txtIndCodEmpresa.Text = "00002"; txtIndNomeEmpresa.Text = "ALEGRA IND E COM LTDA (IND)";
                txtIndVenda.Text = "N";
                txtIndCompra.Text = "S";

                txtCodCalcICMS.Text = codInsumos; txtNomeCalcICMS.Text = calcInsumos;

                if (picSubTribOK.Visible)
                {
                    chkTribEspecifica.Checked = true;

                    txtIndCfop1.Text = "1.151"; txtIndTpMov1.Text = "Entrada"; txtIndCfopEqui1.Text = "1.408";
                    txtIndCfop2.Text = "1.101"; txtIndTpMov2.Text = "Compra"; txtIndCfopEqui2.Text = "1.401";
                    txtIndCfop3.Text = "2.101"; txtIndTpMov3.Text = "Compra"; txtIndCfopEqui3.Text = "2.401";
                }

                if (picAutopecasOK.Visible)
                {

                }

                if (picSemSimilarOK.Visible)
                {
                    
                }

                if (radForBrasileiro.Checked)
                {
                    if (radOrigemNac.Checked)
                    {
                            radOrigem0.Checked = true;
                    }
                    else if(radOrigemImp.Checked)
                    {
                            radOrigem2.Checked = true;
                    }

                }
                else if (radForEstrangeiro.Checked)
                {
                    radOrigem1.Checked = true;
                    radOrigem0.Checked = false;
                    radOrigem2.Checked = false;
                    radOrigem4.Checked = false;

                }
                else if(radForZFM.Checked)
                {
                    if (radOrigemNac.Checked)
                    {
                        if (chkProdutoPPB.Checked)
                        {
                            radOrigem4.Checked = true;
                        }
                        else
                            radOrigem0.Checked = true;
                    }
                    else if (radOrigemImp.Checked)
                    {
                        radOrigem2.Checked = true;
                    }
                }
            }

            #endregion
        }
    }
}

