using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_mrp.controlador.MRP;

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
            int cont = Convert.ToInt32(txt_semanas.Text);
            if (txt_semanas.Text == "")
            {
                MessageBox.Show("Ingrese el numero de semanas", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtg_semanas.Rows.Clear();
                dtg_semanas.Columns.Clear();

                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = "Datos";
                columna.Width = 130;
                columna.ReadOnly = true;
                dtg_semanas.Columns.Add(columna);
                dtg_semanas.Rows.Add("Demanda");

                int num = 1;
                for (int i = 0; i < cant; i++)
                {
                    DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
                    columna1.HeaderText = "semana" + num;
                    columna1.Width = 100;
                    dtg_semanas.Columns.Add(columna1);
                    num++;
                }



            }
            
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            List<int> demanda = new List<int>();
            for (int i = 0; i < dtg_semanas.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtg_semanas.Rows[i].Cells.Count; j++)
                {
                    if (i == 0 && j == 0 || i == 1 && j == 0)
                    {
                        //se evita que entre en los campos de Demada y Dias Laborados
                    }
                    else
                    {
                        
                        string valor = dtg_semanas.Rows[i].Cells[j].Value.ToString();
                        demanda.Add(Convert.ToInt32(valor));
                    }
                }
            }

            if (txt_costoUnidad.Text==""||txt_costoPedir.Text==""||txt_tasaMantenimiento.Text=="")
            {
                MessageBox.Show("Revise los datos ingresados", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdr_L4L.Checked == true)
                {
                    L4L l4 = new L4L(Convert.ToInt16(txt_semanas.Text), Convert.ToDouble(txt_costoPedir.Text), Convert.ToDouble(txt_costoUnidad.Text), Convert.ToDouble(txt_tasaMantenimiento.Text), demanda);
                    l4.get_L4L(dtg_resultado);

                }

                if (rdr_EOQ.Checked == true)
                {
                    EOQ oQ = new EOQ(Convert.ToInt16(txt_semanas.Text), Convert.ToDouble(txt_costoPedir.Text), Convert.ToDouble(txt_costoUnidad.Text), Convert.ToDouble(txt_tasaMantenimiento.Text), demanda);
                    oQ.get_EOQ(dtg_resultado);
                }

                if (rdr_LTC.Checked == true)
                {

                }

                if (rdr_LUC.Checked == true)
                {

                }

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_semanas.Text = "";
            txt_tasaMantenimiento.Text = "";
            txt_costoUnidad.Text = "";
            txt_costoPedir.Text = "";

            dtg_semanas.Rows.Clear();
            dtg_semanas.Columns.Clear();
            dtg_resultado.Rows.Clear();
            dtg_resultado.Columns.Clear();
        }

        private void txt_semanas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_costoUnidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_costoPedir_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_tasaMantenimiento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtg_semanas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void dtg_semanas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dataGridViewTextBoxEditingControl = (DataGridViewTextBoxEditingControl)e.Control;
            dataGridViewTextBoxEditingControl.KeyPress -= new KeyPressEventHandler(this.dtg_semanas_KeyPress);
            dataGridViewTextBoxEditingControl.KeyPress += new KeyPressEventHandler(this.dtg_semanas_KeyPress);
        }

       
    }
}
