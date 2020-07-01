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
        private double tasa;
        private double costo_pedir;
        private double costo_mantenimiento;
        private List<int> demanda = new List<int>();

        public L4L(double tasa, double costo_pedir, double costo_mantenimiento, List<int> demanda)
        {
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

            return dtg_resultado;
        }

        

    }
}
