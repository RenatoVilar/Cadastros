using System;
using System.Drawing;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmModLocalizar : Form
    {
        public int codigo = 0;

        public frmModLocalizar()
        {
            InitializeComponent();

            Size = new Size(630, 380);

            Design modelo = new Design();
            dgvDados = modelo.designDgv(dgvDados);
        }

        public void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                Close();
            }
        }
    }
}
