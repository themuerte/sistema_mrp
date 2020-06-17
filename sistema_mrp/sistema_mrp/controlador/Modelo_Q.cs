using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
    class Modelo_Q
    {
        private int demanda_anual;
        private int costo_producto;
        private int costo_mantenimiento;
        private float costo_pedir;
        private int plazo_entrega;
        private int dias_trabajados;

        public Modelo_Q(int demanda_anual, int costo_producto, int costo_mantenimiento, float costo_pedir, int plazo_entrega, int dias_trabajados)
        {
            this.demanda_anual = demanda_anual;
            this.costo_producto = costo_producto;
            this.costo_mantenimiento = costo_mantenimiento;
            this.costo_pedir = costo_pedir;
            this.plazo_entrega = plazo_entrega;
            this.dias_trabajados = dias_trabajados;
        }

        public double get_Qoptimo()
        {
            double Q_optimo = 0;
            Q_optimo = Math.Sqrt((2 * demanda_anual * costo_pedir) / (costo_mantenimiento));
            Q_optimo = Math.Round(Q_optimo);
            return Q_optimo;
        }

        public int get_pedidosA()
        {
            int num_pedidosA = 0;
            num_pedidosA = demanda_anual / Convert.ToInt32(get_Qoptimo());

            return num_pedidosA;
        }



    }
}
