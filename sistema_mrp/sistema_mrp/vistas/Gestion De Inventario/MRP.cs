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
                    columna1.HeaderText = "periodo" + num;
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

            if (rdr_L4L.Checked == true)
            {
                L4L l4 = new L4L(Convert.ToInt16(txt_semanas.Text), Convert.ToDouble(txt_costoPedir.Text), Convert.ToDouble(txt_costoUnidad.Text), demanda);
                l4.get_L4L(dtg_resultado);
                
            }
            
            if (rdr_EOQ.Checked == true)
            {
                
            }
            
            if (rdr_LTC.Checked == true)
            {
                
            }
            
            if (rdr_LUC.Checked == true)
            {
                
            }

        }



    }
}
