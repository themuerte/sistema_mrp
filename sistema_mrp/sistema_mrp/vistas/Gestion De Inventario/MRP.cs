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

        protected void Carga()
        {
            DataGridViewTextBoxColumn semanas = new DataGridViewTextBoxColumn();
            semanas.HeaderText = "Semana";
            semanas.Width = 100;
            semanas.ReadOnly = true;
            dtg_resultado.Columns.Add(semanas);

            DataGridViewTextBoxColumn demanda = new DataGridViewTextBoxColumn();
            demanda.HeaderText = "Demanda";
            demanda.Width = 100;
            demanda.ReadOnly = true;
            dtg_resultado.Columns.Add(demanda);

            DataGridViewTextBoxColumn produccion = new DataGridViewTextBoxColumn();
            produccion.HeaderText = "Produccion";
            produccion.Width = 100;
            produccion.ReadOnly = true;
            dtg_resultado.Columns.Add(produccion);

            DataGridViewTextBoxColumn inventario_final = new DataGridViewTextBoxColumn();
            inventario_final.HeaderText = "Inventario Final";
            inventario_final.Width = 130;
            inventario_final.ReadOnly = true;
            dtg_resultado.Columns.Add(inventario_final);

            DataGridViewTextBoxColumn costo_mantenimiento = new DataGridViewTextBoxColumn();
            costo_mantenimiento.HeaderText = "Costo de mantenimiento";
            costo_mantenimiento.Width = 100;
            costo_mantenimiento.ReadOnly = true;
            dtg_resultado.Columns.Add(costo_mantenimiento);

            DataGridViewTextBoxColumn costo_envio = new DataGridViewTextBoxColumn();
            costo_envio.HeaderText = "Costo de envio";
            costo_envio.Width = 100;
            costo_envio.ReadOnly = true;
            dtg_resultado.Columns.Add(costo_envio);

            DataGridViewTextBoxColumn costo_total = new DataGridViewTextBoxColumn();
            costo_total.HeaderText = "Costo total";
            costo_total.Width = 100;
            costo_total.ReadOnly = true;
            dtg_resultado.Columns.Add(costo_total);




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
                        //string valor = dtg_semanas.Rows[i].Cells[j].Value.ToString();
                        //MessageBox.Show(valor);
                    }
                }
            }

            if (rdr_L4L.Checked == true)
            {
                Carga();
            }else if (rdr_EOQ.Checked == true)
            {
                Carga();
            }
            else if (rdr_LTC.Checked == true)
            {
                Carga();
            }
            else if (rdr_LUC.Checked == true)
            {
                Carga();
            }

        }



    }
}
