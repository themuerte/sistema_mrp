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
        private double demanda_desv;

        public Modelo_P(int demanda, double plazon_entrega, double periodo_revision, double desviacion, double probabilidad_cumplir, int inventario_actual, double demanda_desv)
        {
            this.demanda = demanda;
            this.plazon_entrega = plazon_entrega;
            this.periodo_revision = periodo_revision;
            this.desviacion = desviacion;
            this.probabilidad_cumplir = probabilidad_cumplir;
            this.inventario_actual = inventario_actual;
            this.demanda_desv = demanda_desv;
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
            double result;
            MathNet.Numerics.Distributions.Normal distribucion;
            distribucion = MathNet.Numerics.Distributions.Normal.WithMeanStdDev(demanda_desv, desviacion);
            result = Math.Sqrt((plazon_entrega+periodo_revision)*distribucion.StdDev);

            return Convert.ToString(result);
        }

        public String get_cantidadOptima()
        {
            int cantidad;
            cantidad = Convert.ToInt16(demanda*(plazon_entrega+periodo_revision) + (Convert.ToDouble(get_z())*Convert.ToDouble(get_desviacionDemanda()))
                - inventario_actual);
            return Convert.ToString(cantidad);
        }



    }
}
