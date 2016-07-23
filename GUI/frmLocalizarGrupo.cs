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
    public partial class frmLocalizarGrupo : frmModLocalizar
    {
        public frmLocalizarGrupo()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
            BLLGrupo bll = new BLLGrupo(dalconexao);
            dgvDados.DataSource = bll.Localizar(txtPesquisar.Text);

            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Grupo";
            dgvDados.Columns[2].HeaderText = "Tipo";
            dgvDados.Columns[0].Width = 80;
            dgvDados.Columns[1].Width = 507;
           ;
        }
    }
}
