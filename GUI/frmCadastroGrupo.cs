using System;
using System.Windows.Forms;
using DAL;
using Modelo;
using BLL;

namespace GUI
{
    public partial class frmCadastroGrupo : frmModFormCadastro
    {
        
        public frmCadastroGrupo()
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
            frmLocalizarGrupo frm = new frmLocalizarGrupo();
            frm.ShowDialog();
            if (frm.codigo != 0)
            {
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLGrupo bll = new BLLGrupo(dalconexao);
                ModeloGrupo modelo = bll.CarregaModeloGrupo(frm.codigo);
                txtNomeGrupo.Text = modelo.NomeGrupo;
                txtGrupoID.Text = modelo.GrupoID.ToString();
                if (modelo.TipoID == 1)
                {
                    radMatPrima.Checked = true;
                }
                if (modelo.TipoID == 2)
                {
                    radInsumos.Checked = true;
                }
                if (modelo.TipoID == 3)
                {
                    radRevenda.Checked = true;
                }

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
            int grupoID = Convert.ToInt32(txtGrupoID.Text);
            try
            {
                DialogResult d = MessageBox.Show("Deseja Excluir o registro", "Aviso", MessageBoxButtons.YesNo);
                    if ((d.ToString() == "Yes" && grupoID == 1) || (d.ToString() == "Yes" && grupoID == 2))
                    {
                        MessageBox.Show("Esse Grupo não pode ser excluido!", "Aviso");
                        LimparTela(this);
                        AlterarBotoes(1);
                        radRevenda.Checked = true;
                    }
                    else if (d.ToString() == "Yes")
                    {
                        DALConexao dalConexao = new DALConexao(DadosDeConexao.strConexao);
                        BLLGrupo bllGrupo = new BLLGrupo(dalConexao);
                        bllGrupo.Excluir(Convert.ToInt32(txtGrupoID.Text));
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
            string grupoID = txtGrupoID.Text;

            try
            {
                ModeloGrupo modelo = new ModeloGrupo();
                modelo.NomeGrupo = txtNomeGrupo.Text;
                modelo.TipoID = GetTipo();
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLGrupo bll = new BLLGrupo(dalconexao);

                if (operacao == "Novo")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show(String.Format("Cadastro efetuado com sucesso !\nO Grupo {0} foi cadastrado com o código: {1}",
                                    txtNomeGrupo.Text.ToUpper(), modelo.GrupoID.ToString()));
                }
                else if (grupoID == "1" || grupoID == "2")
                {
                    MessageBox.Show("Esse Grupo não pode ser alterado!", "Aviso");
                    LimparTela(this);
                    AlterarBotoes(1);
                    radRevenda.Checked = true;
                }
                else
                { 
                    modelo.GrupoID = Convert.ToInt32(txtGrupoID.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show(String.Format("Cadastro alterado com sucesso !\nO Grupo {0} foi alterado",
                                    txtNomeGrupo.Text.ToUpper()));
                }

                LimparTela(this);
                AlterarBotoes(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetTipo()
        {
            Finalidade fin = Finalidade.None;

            if (radRevenda.Checked) { fin = Finalidade.Revenda; }
            if (radMatPrima.Checked) { fin = Finalidade.MatPrima; }
            if (radInsumos.Checked) { fin = Finalidade.Insumos; }

            return Convert.ToInt32(fin);
        }

        private void frmCadastroGrupo_Load(object sender, EventArgs e)
        {
            radInsumos.Enabled = false;
            radMatPrima.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela(this);
            AlterarBotoes(1);
            radRevenda.Checked = true;
        }
    }
}
