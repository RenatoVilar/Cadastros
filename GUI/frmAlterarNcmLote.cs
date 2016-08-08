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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
            BLLNCMLote bll = new BLLNCMLote(dalconexao);
            string indexRadio = CheckRadio(grpBoxFiltro);
            dgvDados.AutoGenerateColumns = false;
            dgvDados.DataSource = bll.Localizar(txtPesquisar.Text, indexRadio);
            

            dgvDados.Columns[0].HeaderText = "NCM";
            dgvDados.Columns[1].HeaderText = "Descrição";
            dgvDados.Columns[2].HeaderText = indexRadio;
            dgvDados.Columns[0].Width = 90;
            dgvDados.Columns[1].Width = 497;
        }

        private string CheckRadio(Control control)
        {
            string radName = "";

            foreach (Control crtl in Controls)
            {
                if (crtl.GetType().ToString() == "System.Windows.Forms.RadioButton")
                    if (((RadioButton)crtl).Checked == true)
                        radName = crtl.Text;
            }

            return radName;
        }
    }
 }
