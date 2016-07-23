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

namespace GUI
{
    public partial class frmLocalizarCalcICMS : frmModLocalizar
    {
        public frmLocalizarCalcICMS()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao dalConexao = new DALConexao(DadosDeConexao.strConexao);
            BLLCalcICMS bll = new BLLCalcICMS(dalConexao);
            dgvDados.DataSource = bll.Localizar(txtPesquisar.Text);

            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Cálculo ICMS";
            dgvDados.Columns[0].Width = 80;
            dgvDados.Columns[1].Width = 507;
        }
    }
}
