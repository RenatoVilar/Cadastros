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
            dgvDados.DataSource = bll.Localizar(txtPesquisarNCM.Text);
            dgvDados.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dgvDados.EnableHeadersVisualStyles = false;
            dgvDados.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvDados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
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
            lblCritérioText.Text = txtPesquisarNCM.Text;

        }

        private void dataGridView1_CellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "1")
                    {
                        e.Value = true;
                    }
                    else if (e.Value.ToString() == "0")
                    {
                        e.Value = false;
                    }
                }
            }
        }

        private string CheckRadio(GroupBox grp)
        {
            return grp.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            

            //RadioButton res = null;

            //foreach (Control crtl in controle.Controls)
            //{
            //    if (crtl is GroupBox)
            //    {
            //        res = Controls..OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //     }
            //}

            //return res.Name;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloNCM modelo = new ModeloNCM();
                modelo.CodNCM = txtPesquisarNCM.Text;
                modelo.SitST = radSubsTrib.Checked ? 1 : 0;
                //modelo.SitAuto = radAutopecas.Checked ? 1 : 0;
                //modelo.SitSemSimilar = radSemSimilar.Checked ? 1 : 0;
                //mtxtCest.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                //modelo.Cest = mtxtCest.Text;
                DALConexao dalconexao = new DALConexao(DadosDeConexao.strConexao);
                BLLNCMLote bll = new BLLNCMLote(dalconexao);
                bll.Alterar(modelo);
                MessageBox.Show($"As NCMs iniciadas por {txtPesquisarNCM.Text} foram alteradas com sucesso !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    
