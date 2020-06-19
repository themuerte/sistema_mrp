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
        private int tiempo_espera;

        public Modelo_Q(double demanda_anual, double costo_producto, double costo_mantenimiento, double costo_pedir, int plazo_entrega, int dias_trabajados, int tiempo_espera)
        {
            this.demanda_anual = demanda_anual;
            this.costo_producto = costo_producto;
            this.costo_mantenimiento = costo_mantenimiento;
            this.costo_pedir = costo_pedir;
            this.plazo_entrega = plazo_entrega;
            this.dias_trabajados = dias_trabajados;
            this.tiempo_espera = tiempo_espera;
        }

        public int get_Qoptimo()
        {
            double Q_optimo = 0;
            Q_optimo = Math.Sqrt((2 * demanda_anual * costo_pedir) / (costo_mantenimiento));
            Q_optimo = Math.Round(Q_optimo);
            return Convert.ToInt32( Q_optimo);
        }

        public int get_pedidosA()
        {
            int num_pedidosA = 0;
            num_pedidosA = Convert.ToInt32(demanda_anual / get_Qoptimo());
            return num_pedidosA;
        }

        public double get_tiempoEntreP()
        {
            double tiempo_entreP;
            tiempo_entreP = get_Qoptimo() / demanda_anual;
            return tiempo_entreP;
        }
        
        public double get_inventarionSeguridad()
        {
            double inv_seguridad = 0;
            inv_seguridad = (demanda_anual / dias_trabajados) * tiempo_espera;
            return inv_seguridad;

        }
      



    }
}
