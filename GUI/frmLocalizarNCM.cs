using System;
using DAL;
using BLL;


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
    }
}
