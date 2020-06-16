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
        private int dias_trabajados;

        public Modelo_Q(int demanda_anual, int costo_producto, int costo_mantenimiento, float costo_pedir, int dias_trabajados)
        {
            this.demanda_anual = demanda_anual;
            this.costo_producto = costo_producto;
            this.costo_mantenimiento = costo_mantenimiento;
            this.costo_pedir = costo_pedir;
            this.dias_trabajados = dias_trabajados;
        }



    }
}
