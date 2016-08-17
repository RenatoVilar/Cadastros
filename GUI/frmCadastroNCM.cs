using System;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;

namespace GUI
{
    public partial class frmCadastroNCM : frmModFormCadastro
    {
        

        public frmCadastroNCM()
        {
            InitializeComponent();
        }

        private void frmCadastroNCM_Load(object sender, EventArgs e)
        {
            mtxtCest.Mask = "00,000,00";
            mtxtNcm.Mask = "00,0000,00";
            //mtxtCest.MaskInputRejected += new MaskInputRejectedEventHandler(mtxtCEST_MaskInputRejected);
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "Novo";
            AlterarBotoes(2);
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
                mtxtNcm.Text = modelo.CodNCM;
                txtNomeNCM.Text = modelo.NomeNCM;
                chkST.Checked = Convert.ToBoolean(modelo.SitST);
                chkSemSimilar.Checked = Convert.ToBoolean(modelo.SitSemSimilar);
                chkAutopecas.Checked = Convert.ToBoolean(modelo.SitAuto);
                mtxtCest.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mtxtCest.Text = modelo.Cest;
                AlterarBotoes(3);
            }
            else
            {
                LimparTela(this);
                AlterarBotoes(1);
            }
            frm.Dispose();

        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            AlterarBotoes(2);
            mtxtNcm.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja Excluir o Registo ?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLNCM bll = new BLLNCM(dalconexao);
                bll.Excluir(Convert.ToInt32(mtxtNcm.Text));
                LimparTela(this);
                AlterarBotoes(1);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            mtxtNcm.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            try
            {
                ModeloNCM modelo = new ModeloNCM();
                modelo.NomeNCM = txtNomeNCM.Text;
                modelo.CodNCM = mtxtNcm.Text;
                modelo.SitST = chkST.Checked ? 1 : 0;
                modelo.SitAuto = chkAutopecas.Checked ? 1 : 0;
                modelo.SitSemSimilar = chkSemSimilar.Checked ? 1 : 0;
                mtxtCest.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                modelo.Cest = mtxtCest.Text;
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLNCM bll = new BLLNCM(dalconexao);

                if (operacao == "Novo")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show(String.Format("Cadastro efetuado com sucesso !\nA NCM {0} - {1}\n foi cadastrada com o código: {2}",
                                    mtxtNcm.Text, txtNomeNCM.Text.ToUpper(), modelo.NCMID.ToString()));
                }
                else
                {
                    modelo.CodNCM = mtxtNcm.Text;
                    bll.Alterar(modelo);
                    MessageBox.Show(String.Format("Cadastro alterado com sucesso !\nA NCM {0} - {1} foi alterada!",
                                    mtxtNcm.Text, txtNomeNCM.Text.ToUpper()));
                }

                LimparTela(this);
                AlterarBotoes(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      }
}
