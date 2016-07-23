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
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmLocalizarTpProduto : frmModLocalizar
    {
        public frmLocalizarTpProduto()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
            BLLTpProduto bll = new BLLTpProduto(dalconexao);
            dgvDados.DataSource = bll.Localizar(txtPesquisar.Text);

            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[0].Width = 80;
            dgvDados.Columns[1].Width = 507;
        }
    }

}
