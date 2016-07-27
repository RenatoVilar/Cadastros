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
using BLL;
using DAL;
using System.Data.SqlClient;



namespace GUI
{
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            FillCbo();
            ApagaPics();
           
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
            SqlCommand sqlCmd = new SqlCommand();
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
            }
            frm.Dispose();
        }

        private void GetRadChecked()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is GroupBox)
                {
                    foreach (Control radio in ctrl.Controls)
                    {
                        if (((RadioButton)radio).Checked)
                        {
                            FillCbo();
                        }

                    }
                }
            }
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            GetRadChecked();
        }

        public void LimparTela(Control tabPage)
        {
            foreach (Control ctrl in tabPage.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = String.Empty;
                }
                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }
                else if (ctrl.HasChildren)
                {
                    LimparTela(ctrl);
                }
            }
        }

        private void ApagaPics()
        {
            picSubTribOK.Visible = false;
            picAutopecasOK.Visible = false;
            picSemSimilarOK.Visible = false;
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
                    throw new Exception("Verifique a NCM do Produto e o Tipo!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
           

            LimparTela(tabPrincipal);
            ProcessFinalidade();
        }

        private void radForEstrangeiro_Click(object sender, EventArgs e)
        {
            radOrigemNac.Checked = false;
            radOrigemNac.Enabled = false;
            radOrigemImp.Checked = true;
        }

        private void radForBrasileiro_Click(object sender, EventArgs e)
        {
            radOrigemNac.Enabled = true;
        }

        private void radForZFM_Click(object sender, EventArgs e)
        {
            radOrigemNac.Enabled = true;
        }

        private void txtCodNCM_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodNCM.TextLength < 8 || txtCodNCM.Text.Where(c => char.IsLetter(c)).Count() > 0)
            {
                MessageBox.Show("A NCM deve ter 8 números");
                txtNomeNCM.Text = "";
                txtCodNCM.Text = "";
                ApagaPics();
                LimparTela(tabPrincipal);
            }
        }
    }
}

