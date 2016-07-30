using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
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

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            TreeNode mnuEnderecos= trePrincipal.Nodes.Add("Endereços...");
            TreeNode mnuAdicionais = trePrincipal.Nodes.Add("Adicionais...");
            TreeNode mnuCadastros= trePrincipal.Nodes.Add("Cadastros...");
            TreeNode mnuCaracteristicas = trePrincipal.Nodes.Add("Características...");
        }
    }
}
