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

        private void trePrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            

           
        }

        TreeNode myNode;

        private void trePrincipal_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            myNode = e.Node;

            //if (myNode.Index == 1)
            //{
            //    pnlAdicionais.Visible = true;
            //    pnlEndereco.Visible = false;
            //}
            switch (myNode.Index)
            {
                case 0:
                    pnlEndereco.Visible = true;
                    pnlAdicionais.Visible = false;
                    break;
                case 1:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = true;
                    break;
                case 2:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = false;
                    break;
                case 3:
                    pnlEndereco.Visible = false;
                    pnlAdicionais.Visible = false;
                    break;
            }
           



        }
    }
}
