using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmModFormCadastro : Form
    {
        public string operacao;

        public frmModFormCadastro()
        {
            InitializeComponent();
        }

        public void AlterarBotoes(int op)
        {

            //1 - Prepara os botões para Inserir e Localizar
            //2 - Prepora os botões para Alterar 
            //3 - Prepara os botões para Excluir ou Alterar

            pnDados.Enabled = false;
            btnNovo.Enabled = false;
            btnLocalizar.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;

            if (op == 1)
            {
                btnNovo.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }

        public void LimparTela(Control controles)
        {
            foreach (Control ctrl in controles.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = String.Empty;
                }
                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Text = String.Empty;
                }
                else if (ctrl.Controls.Count > 0)
                {
                    LimparTela(ctrl);
                }
            }
        }

        private void frmModFormCadastro_Load(object sender, EventArgs e)
        {
            AlterarBotoes(1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela(this);
            AlterarBotoes(1);
        }
    }
}
