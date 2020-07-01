using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sistema_mrp.controlador.MRP
{
    class L4L
    {
        private int semanas;
        private double tasa;
        private double costo_pedir;
        private double costo_mantenimiento;
        private List<int> demanda = new List<int>();

        public L4L(int semanas, double tasa, double costo_pedir, double costo_mantenimiento, List<int> demanda)
        {
            this.semanas = semanas;
            this.tasa = tasa;
            this.costo_pedir = costo_pedir;
            this.costo_mantenimiento = costo_mantenimiento;
            this.demanda = demanda;
        }

        DataGridView dtg_resultado = new DataGridView();

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

        public DataGridView get_L4L()
        {
            Carga();
            for (int i = 1; i == semanas + 1 ; i++)
            {
                for (int j = 1; j == 8; j++)
                {
                    if (i == 0)
                    {
                        //se evita que entre en los campos de Datos
                    }
                    else
                    {
                        switch (j)
                        {
                            //semana
                            case 1:
                                    dtg_resultado.Columns.Add(new DataGridViewColumn(){HeaderText= i.ToString() });
                                break;

                            //demanda
                            case 2:
                                dtg_resultado.Columns.Add(new DataGridViewColumn() { HeaderText = demanda[i].ToString() });
                                break;

                            //produccion
                            case 3:
                                dtg_resultado.Columns.Add(new DataGridViewColumn() { HeaderText = demanda[i].ToString() });
                                break;
                            
                            //inventario final
                            case 4:
                                break;
                            
                            //costo de mantenimiento
                            case 5:
                                break;
                            
                            //costo de envio
                            case 6:
                                dtg_resultado.Columns.Add(new DataGridViewColumn() { HeaderText = costo_pedir.ToString()});
                                break;
                            
                            //costo total
                            case 7:
                                double valor0 = Convert.ToDouble(dtg_resultado.Rows[i - 1].Cells[7].Value);
                                double valor1 = Convert.ToDouble(dtg_resultado.Rows[i].Cells[7].Value);
                                dtg_resultado.Columns.Add(new DataGridViewColumn() { HeaderText = Convert.ToString(valor0+valor1) }) ;
                                break;
                          

                        }
                    }
                }
            }

            return dtg_resultado;
        }

        

    }
}
