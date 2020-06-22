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
     
        public Modelo_P(int demanda, double plazon_entrega, double periodo_revision, double desviacion, double probabilidad_cumplir)
        {
            this.demanda = demanda;
            this.plazon_entrega = plazon_entrega;
            this.periodo_revision = periodo_revision;
            this.desviacion = desviacion;
            this.probabilidad_cumplir = probabilidad_cumplir;
        }

        public String get_z()
        {
            double z;
            MathNet.Numerics.Distributions.Normal result = new MathNet.Numerics.Distributions.Normal();
            z = result.CumulativeDistribution(probabilidad_cumplir);
            return Convert.ToString(z);
        }



    }
}
