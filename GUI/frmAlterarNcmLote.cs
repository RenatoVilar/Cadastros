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
            //dgvDados.AutoGenerateColumns = false;
            dgvDados.DataSource = bll.Localizar(txtPesquisarNCM.Text);
            //DataGridViewCheckBoxColumn dgvcb = new DataGridViewCheckBoxColumn();
            //dgvcb.TrueValue = 1;
            //dgvcb.FalseValue = 0;
            //dgvDados.Columns.Add(dgvcb);
            //dgvDados.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormating);


            //dgvDados.Columns[0].HeaderText = "NCM";
            //dgvDados.Columns[1].HeaderText = "Descrição";
            //dgvDados.Columns[2].HeaderText = indexRadio;
            //dgvDados.Columns[0].Width = 90;
            //dgvDados.Columns[1].Width = 497;
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
    }
}
