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
        }

        private void groupBox1_CheckedChanged(object sender, EventArgs e)
        {
            FillCbo();
        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            FillCbo();
            ApagaPics();
            mtxtCest.Mask = "00,000,00";


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
           
            modelo.LimparTela(tabPrincipal);
            AvaliarDadosProdutos();
      
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
                modelo.LimparTela(tabPrincipal);
            }
        }
    }
}

