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
    public partial class frmAlterarNcmLote : Form
    {
        

        public frmAlterarNcmLote()
        {
            InitializeComponent();
        }

        private void frmAlterarNcmLote_Load(object sender, EventArgs e)
        {
            mtxtCest.Mask = "00,000,00";
            mtxtNcm.Mask = "00,0000,00";

            dgvDados.BackgroundColor = Color.White;

        }
 
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
            BLLNCMLote bll = new BLLNCMLote(dalconexao);

            mtxtNcm.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            dgvDados.DataSource = bll.Localizar(mtxtNcm.Text);
            if (dgvDados.RowCount == 1)
            {
                MessageBox.Show("Nenhum registro encontrado! ", "Atenção !", MessageBoxButtons.OK);
            }

            dgvDados.EnableHeadersVisualStyles = false;


            dgvDados.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dgvDados.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvDados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvDados.CellFormatting += new DataGridViewCellFormattingEventHandler(DgvDados_CellFormatting);

            dgvDados.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvDados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dgvDados.MultiSelect = false;

            dgvDados.Columns[0].HeaderText = "NCM";
            dgvDados.Columns[1].HeaderText = "Descrição";
            dgvDados.Columns[2].HeaderText = "Subs Tributária";
            dgvDados.Columns[3].HeaderText = "Autopeças";
            dgvDados.Columns[4].HeaderText = "Sem Similar Nac";
            dgvDados.Columns[5].HeaderText = "CEST";
            dgvDados.Columns[0].Width = 65;
            dgvDados.Columns[1].Width = 250;
            dgvDados.ReadOnly = true;

            lblCriterioAtual.Visible = true;
            lblCritérioText.Visible = true;
            lblCritérioText.Text = mtxtNcm.Text;

        }

        private void DgvDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Double d;
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);
                e.Value = d.ToString(@"##\.###\.##");
            }
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);
                e.Value = d.ToString(@"##\.####\.##");
            }
        }

        public int apagar;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (chkApagar.Checked)
            {
                DialogResult result;
                result = MessageBox.Show("Ao selecionar \"Apagar\" todas as informações do Tipo Selecionado seráo apagadas!", "ATENÇÃO", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) { apagar = 1; }
                else { apagar = 0; }
            }
                
            try
            {
                ModeloNCM modelo = new ModeloNCM();
                mtxtNcm.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                modelo.CodNCM = mtxtNcm.Text;
                modelo.SitST = radSubsTrib.Checked ? 1 : 0;
                modelo.SitAuto = radAutopecas.Checked ? 1 : 0;
                modelo.SitSemSimilar = radSemSimilar.Checked ? 1 : 0;
                mtxtCest.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                modelo.Cest = mtxtCest.Text;
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLNCMLote bll = new BLLNCMLote(dalconexao);
                bll.Alterar(modelo, apagar);
                MessageBox.Show($"As NCMs iniciadas por {mtxtNcm.Text} foram alteradas com sucesso !");
                mtxtCest.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkApagar_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCest.Text = "";
            mtxtCest.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvDados.DataSource = null;
        }

        private void radCest_CheckedChanged(object sender, EventArgs e)
        {
            mtxtCest.Enabled = true;
        }
    }
}
    
