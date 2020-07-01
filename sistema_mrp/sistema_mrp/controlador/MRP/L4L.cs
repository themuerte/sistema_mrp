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
        private double costo_pedir;
        private double costo_unitario;
        private double tasa_mantenimiento;
        private List<int> demanda = new List<int>();

        public L4L(int semanas, double costo_pedir, double costo_unitario, double tasa_mantenimiento, List<int> demanda)
        {
            this.semanas = semanas;
            this.costo_pedir = costo_pedir;
            this.costo_unitario = costo_unitario;
            this.tasa_mantenimiento = tasa_mantenimiento;
            this.demanda = demanda;
        }

        public void get_L4L(DataGridView dtg_resultado)
        {
            DataGridViewTextBoxColumn semanas1 = new DataGridViewTextBoxColumn();
            semanas1.HeaderText = "Semana";
            semanas1.Width = 100;
            semanas1.ReadOnly = true;
            dtg_resultado.Columns.Add(semanas1);

            DataGridViewTextBoxColumn demanda1 = new DataGridViewTextBoxColumn();
            demanda1.HeaderText = "Demanda";
            demanda1.Width = 100;
            demanda1.ReadOnly = true;
            dtg_resultado.Columns.Add(demanda1);

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

            DataGridViewTextBoxColumn costo_mantenimiento1 = new DataGridViewTextBoxColumn();
            costo_mantenimiento1.HeaderText = "Costo de mantenimiento";
            costo_mantenimiento1.Width = 100;
            costo_mantenimiento1.ReadOnly = true;
            dtg_resultado.Columns.Add(costo_mantenimiento1);

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

            double costo = 0;
            for (int i = 0; i < semanas; i++)
            {
                costo += costo_pedir;
                dtg_resultado.Rows.Add(new object[] {i + 1, demanda[i],demanda[i],0,0,costo_pedir,costo});
            }


           
        }
       

        

    }
}
