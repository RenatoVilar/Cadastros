using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    class Design
    {
        public DataGridView designDgv(DataGridView dgv)
        {
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgv.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.MultiSelect = false;

            return dgv;
        }
    }

    public enum Finalidade
    {
        None,   // int value 0
        MatPrima, // int value 1
        Insumos, // int value 2
        Revenda // int value 3
    };
}
