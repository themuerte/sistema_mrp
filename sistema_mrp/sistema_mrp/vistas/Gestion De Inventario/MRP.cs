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

        protected void validando_tabla(DataGridView tabla)
        {

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

                int num = 1;
                for (int i = 0; i < cant; i++)
                {
                    DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
                    columna1.HeaderText = "periodo" + num;
                    columna1.Width = 130;
                    dtg_semana.Columns.Add(columna1);
                    num++;
                }
                

                

            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            for(int i =0; i < dtg_semana.Rows.Count - 1; i++)
            {
                for (int j = 0;j < dtg_semana.Rows[i].Cells.Count; j++)
                {
                    if (i == 0 && j == 0||i==1 && j == 0)
                    {
                        //se evita que entre en los campos de Demada y Dias Laborados
                    }
                    else
                    {
                        string valor = dtg_semana.Rows[i].Cells[j].Value.ToString();
                        MessageBox.Show(valor);
                    }
                }
            }
        }

        private void dtg_semana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
