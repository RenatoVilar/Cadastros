using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
            chkPrestadorServico.Visible = false;

            for (int i = 0; i < grpTipo.Controls.Count; i++)
            {
                RadioButton rdb = (RadioButton)grpTipo.Controls[i];
                rdb.CheckedChanged += new EventHandler(Rdb_CheckedChanged);
            }
        }

        private void Rdb_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rdb in grpTipo.Controls)
            {
                if (rdb.Name == "radJuridica")
                {
                    chkPrestadorServico.Visible = true;
                }
                else chkPrestadorServico.Visible = false;
            }
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            TreeNode mnuEnderecos= trePrincipal.Nodes.Add("Endereços...");
            TreeNode mnuAdicionais = trePrincipal.Nodes.Add("Adicionais...");
            TreeNode mnuCadastros= trePrincipal.Nodes.Add("Cadastros...");
            TreeNode mnuCaracteristicas = trePrincipal.Nodes.Add("Características...");

            pnlEndereco.Visible = true;
        }
        private void trePrincipal_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode myNode;

            myNode = e.Node;

            switch (myNode.Index)
            {
                case 0:
                    pnlEndereco.Visible = true;
                    pnlAdicionais.Visible = false;
                    pnlCadastros.Visible = false;
                    pnlCaracteristicas.Visible = false;
                    break;
                case 1:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = true;
                    pnlCadastros.Visible = false;
                    pnlCaracteristicas.Visible = false;
                    break;
                case 2:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = false;
                    pnlCadastros.Visible = true;
                    pnlCaracteristicas.Visible = false;
                    break;
                case 3:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = false;
                    pnlCadastros.Visible = false;
                    pnlCaracteristicas.Visible = true;
                    break;
            }
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            Design modelo = new Design();
            modelo.LimparTela(pnlAdicionais);
            modelo.LimparTela(pnlCadastros);
            modelo.LimparTela(pnlCaracteristicas);
            modelo.LimparTela(pnlEndereco);
            AvaliarDadosCliente();
        }

        private void radJuridica_Click(object sender, EventArgs e)
        {
            chkPrestadorServico.Visible = true;
        }

        private void radFisica_CheckedChanged(object sender, EventArgs e)
        {
            chkPrestadorServico.Visible = false;
        }
    }
}
