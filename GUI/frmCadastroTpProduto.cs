using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;


namespace GUI
{
    public partial class frmCadastroTpProduto : frmModFormCadastro
    {
        public frmCadastroTpProduto()
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
            frmLocalizarTpProduto frm = new frmLocalizarTpProduto();
            frm.ShowDialog();
            if (frm.codigo != 0)
            {
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLTpProduto bll = new BLLTpProduto(dalconexao);
                ModeloTpProduto modelo = bll.CarregaModeloTpProduto(frm.codigo);
                txtNomeTipo.Text = modelo.NomeTipo;
                txtTipoID.Text = modelo.TipoID.ToString();
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
                DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                    BLLTpProduto bll = new BLLTpProduto(dalconexao);
                    bll.Excluir(Convert.ToInt32(txtTipoID.Text));
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
                ModeloTpProduto modelo = new ModeloTpProduto();
                modelo.NomeTipo = txtNomeTipo.Text;
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLTpProduto bll = new BLLTpProduto(dalconexao);

                if (operacao == "Novo")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show(String.Format("Cadastro efetuado com sucesso !\nO Tipo de produto {0} foi cadastrado com o código: {1}",
                                    txtNomeTipo.Text.ToUpper(), modelo.TipoID.ToString()));
                }
                else
                {
                    modelo.TipoID = Convert.ToInt32(txtTipoID.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show(String.Format("Cadastro alterado com sucesso !\nO Tipo de produto {0} foi alterado com o código: {1}",
                                    txtNomeTipo.Text.ToUpper(), modelo.TipoID.ToString()));
                }

                LimparTela(this);
                AlterarBotoes(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
