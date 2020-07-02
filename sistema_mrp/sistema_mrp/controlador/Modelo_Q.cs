using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
    class Modelo_Q
    {
        private double demanda_anual;
        private double costo_producto;
        private double costo_mantenimiento;
        private double costo_pedir;
        private int plazo_entrega;
        private int dias_trabajados;

        public Modelo_Q(double demanda_anual, double costo_producto, double costo_mantenimiento, double costo_pedir, int plazo_entrega, int dias_trabajados)
        {
            this.demanda_anual = demanda_anual;
            this.costo_producto = costo_producto;
            this.costo_mantenimiento = costo_mantenimiento;
            this.costo_pedir = costo_pedir;
            this.plazo_entrega = plazo_entrega;
            this.dias_trabajados = dias_trabajados;
        }

        public String get_Qoptimo()
        {
            double Q_optimo = 0;
            Q_optimo = Math.Sqrt((2 * demanda_anual * costo_pedir) / (costo_mantenimiento));
            Q_optimo = Math.Round(Q_optimo);
            return Convert.ToString(Q_optimo);
        }

        public String get_pedidosA()
        {
            int num_pedidosA = 0;
            num_pedidosA = Convert.ToInt32(demanda_anual / Convert.ToInt32(get_Qoptimo()));
            return Convert.ToString(num_pedidosA);
        }

        public String get_tiempoEntreP()
        {
            double tiempo_entreP;
            tiempo_entreP = demanda_anual /Convert.ToDouble(get_Qoptimo()) ;
            return Convert.ToString(tiempo_entreP);
        }

        public String get_inventarionSeguridad()
        {
            int inv_seguridad = 0;
            inv_seguridad = Convert.ToInt32((demanda_anual / dias_trabajados) * plazo_entrega);
            return Convert.ToString( inv_seguridad);

        }


        public String get_costoTotal()
        {
            double costo_total = 0;
            double costo_ordenar = (demanda_anual / Convert.ToDouble(get_Qoptimo())) / costo_pedir;
            double costos_mantener = (Convert.ToDouble(get_Qoptimo()) / 2) * costo_mantenimiento;
            double costo_invetanrio = demanda_anual * costo_producto;

            costo_total = costo_ordenar + costo_invetanrio + costos_mantener;

            return Convert.ToString(costo_total);
        }


    }
}
