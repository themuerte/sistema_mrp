using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_mrp.controlador
{
    class Trucazos
    {
        public static void vaciarDataGridView(DataGridView dgv)
        {
            while (dgv.Rows.Count > 1)
            {
                dgv.Rows.Remove(dgv.Rows[0]);
            }
        }
        public static void expandirColumna(DataGridView dtv)
        {
            dtv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
