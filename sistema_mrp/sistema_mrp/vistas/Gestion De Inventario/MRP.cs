using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    public partial class MRP : Form
    {
        public MRP()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txt_semanas.Text);

            if (txt_semanas.Text == "" || txt_semanas.Text == "")
            {
                MessageBox.Show("Verifique las semanas", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtg_semana.Columns.Clear();
                dtg_semana.Rows.Clear();

                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = "Datos";
                columna.Width = 130;
                columna.ReadOnly = true;
                dtg_semana.Columns.Add(columna);
                dtg_semana.Rows.Add("Demanda");
                dtg_semana.Rows.Add("Dias laborados");

                int i = 0;
                

                

            }
        }
    }
}
