using System;
using DAL;
using BLL;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLocalizarNCM : frmModLocalizar
    {
        public frmLocalizarNCM()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
            BLLNCM bll = new BLLNCM(dalconexao);
            int indexCboBox = cboLocalizarNCM.SelectedIndex;
            dgvDados.DataSource = bll.Localizar(txtPesquisar.Text, indexCboBox);
            if (dgvDados.RowCount == 0)
            {
                MessageBox.Show("Nenhum registro encontrado! ", "Atenção !", MessageBoxButtons.OK);
            }

            dgvDados.CellFormatting += new DataGridViewCellFormattingEventHandler(DgvDados_CellFormatting);

            dgvDados.Columns[0].HeaderText = "NCM";
            dgvDados.Columns[1].HeaderText = "Descrição";
            dgvDados.Columns[0].Width = 90;
            dgvDados.Columns[1].Width = 497;
        }

        private void frmLocalizarNCM_Load(object sender, EventArgs e)
        {
            cboLocalizarNCM.Items.Add("NCM");
            cboLocalizarNCM.Items.Add("Descrição");
            cboLocalizarNCM.SelectedIndex = 0;
        }

        private void DgvDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Double d;
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);
                e.Value = d.ToString(@"##\.####\.##");
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnLocalizar_Click(sender, e);
            }
        }
    }
}
