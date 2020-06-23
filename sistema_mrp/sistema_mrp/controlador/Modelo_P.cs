using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
    class Modelo_P
    {
        private int demanda;
        private double plazon_entrega;
        private double periodo_revision;
        private double desviacion;
        private double probabilidad_cumplir;
        private int inventario_actual;

        public Modelo_P(int demanda, double plazon_entrega, double periodo_revision, double desviacion, double probabilidad_cumplir, int inventario_actual)
        {
            this.demanda = demanda;
            this.plazon_entrega = plazon_entrega;
            this.periodo_revision = periodo_revision;
            this.desviacion = desviacion;
            this.probabilidad_cumplir = probabilidad_cumplir;
            this.inventario_actual = inventario_actual;
        }

        public String get_z()
        {
            double z;
            MathNet.Numerics.Distributions.Normal result = new MathNet.Numerics.Distributions.Normal();
            z = result.InverseCumulativeDistribution(probabilidad_cumplir);
            return Convert.ToString(z);
        }

        public String get_desviacionDemanda()
        {

            double desv_demanda;
            MathNet.Numerics.Distributions.Normal result = new MathNet.Numerics.Distributions.Normal();
            desv_demanda = result.WithMeanStdDev(Convert.ToDouble(periodo_revision + plazon_entrega), desviacion, randomSource = null);

            return Convert.ToString(desv_demanda);
        }

        public String get_cantidadOptima()
        {
            int cantidad;
            cantidad = Convert.ToInt32(demanda*(plazon_entrega+periodo_revision) + (Convert.ToDouble(get_z())*Convert.ToDouble(get_desviacionDemanda()))
                - inventario_actual);
            return Convert.ToString(cantidad);      
        }



    }
}
