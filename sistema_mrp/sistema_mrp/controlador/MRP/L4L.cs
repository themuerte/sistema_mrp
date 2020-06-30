using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
         

    }
}
