using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;

namespace GUI
{
    public partial class frmCadastroCalcICMS : frmModFormCadastro
    {
        public frmCadastroCalcICMS()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "Novo";
            AlterarBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmLocalizarCalcICMS frm = new frmLocalizarCalcICMS();
            frm.ShowDialog();
            if (frm.codigo != 0)
            {
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLCalcICMS bll = new BLLCalcICMS(dalconexao);
                ModeloCalcICMS modelo = bll.CarregaModeloCalcICMS(frm.codigo);
                txtNomeCalc.Text = Convert.ToString(modelo.NomeCalc);
                txtCalcID.Text = Convert.ToString(modelo.CalcID);
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
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao dalConexao = new DALConexao(DadosDeConexao.strConexao);
                    BLLCalcICMS bllCalcICMS = new BLLCalcICMS(dalConexao);
                    bllCalcICMS.Excluir(Convert.ToInt32(txtCalcID.Text));
                    LimparTela(this);
                    AlterarBotoes(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o registro!" + ex);
                AlterarBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCalcICMS modelo = new ModeloCalcICMS();
                modelo.NomeCalc = txtNomeCalc.Text;
                DALConexao dalcConexao = new DALConexao(DadosDeConexao.strConexao);
                BLLCalcICMS bllCalcICMS = new BLLCalcICMS(dalcConexao);

                if (operacao == "Novo")
                {
                    bllCalcICMS.Incluir(modelo);
                    MessageBox.Show(String.Format("Cadastro efetuado com sucesso !\nO Cálculo de ICMS {0} foi cadastrado com o código: {1}",
                                    txtNomeCalc.Text.ToUpper(), modelo.CalcID.ToString()));
                }
                else
                {
                    bllCalcICMS.Alterar(modelo);
                    MessageBox.Show(String.Format("Cadastro alterado com sucesso !\nO Cálculo de ICMS {0} foi alterado",
                                    txtNomeCalc.Text.ToUpper()));
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
