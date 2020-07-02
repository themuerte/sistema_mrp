using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_mrp.controlador;
namespace sistema_mrp.controlador.plan_agregado
{
    class FuerzaNivelada
    {
        Producto prod;
        Empresa empresa;
        int numeroPeriodos;
        double[] aDemanda;
        double[] aDiasHabiles;

        // con bd
        public FuerzaNivelada(int numPeriodo, Producto prod, Empresa empresa)
        {
            NumPeriodo = numPeriodo;
            Prod = prod;
            Empresa = empresa;
            aDemanda = PlanProducto.GetDemandaEstimadaByProducto(prod.IdProducto);
            aDiasHabiles = PlanAgregado.getDiasHabiles();
        }
        // sin bd
        public FuerzaNivelada(int numPeriodo, Producto prod, double[] aDemanda, double[] aDiasHabiles, Empresa empresa)
        {
            NumPeriodo = numPeriodo;
            Prod = prod;
            ADemanda = aDemanda;
            ADiasHabiles = aDiasHabiles;
            Empresa = empresa;
        }

        public int NumPeriodo { get => numeroPeriodos; set => numeroPeriodos = value; }
        public Producto Prod { get => prod; set => prod = value; }
        public double[] ADemanda { get => aDemanda; set => aDemanda = value; }
        public double[] ADiasHabiles { get => aDiasHabiles; set => aDiasHabiles = value; }
        internal Empresa Empresa { get => empresa; set => empresa = value; }

        public List<Fila> getPlanAgregado()
        {
            Fila inventarioInicial, demanda, stockSeguridad, inventarioFinal, produccionRequerida,produccionReal, hrsDisponibles, ctsFaltante, ctsMant, tiempoNormal;

            inventarioInicial = new Fila("Inventario inicial");
            inventarioInicial.Valores = new double[NumPeriodo];
            demanda = new Fila("Demanda");
            demanda.Valores = new double[NumPeriodo];
            stockSeguridad = new Fila("Stock de Seguridad");
            stockSeguridad.Valores = new double[NumPeriodo];
            inventarioFinal = new Fila("Inventario Final");
            inventarioFinal.Valores = new double[NumPeriodo];
            produccionRequerida = new Fila("Producción Requerida");
            produccionRequerida.Valores = new double[NumPeriodo];
            produccionReal = new Fila("Producción Real");
            produccionReal.Valores = new double[NumPeriodo];
            hrsDisponibles = new Fila("Horas Disponibles");
            hrsDisponibles.Valores = new double[NumPeriodo];
            ctsFaltante = new Fila("Costo Faltante");
            ctsFaltante.Valores = new double[NumPeriodo];
            ctsMant = new Fila("Costo Mantenimiento");
            ctsMant.Valores = new double[NumPeriodo];
            tiempoNormal = new Fila("Tiempo Normal");
            tiempoNormal.Valores = new double[NumPeriodo];


            // calculo de la primera parte para calculo real de la producción
            for (int i = 0; i < NumPeriodo; i++)
            {
                // inventario inicial
                if (i == 0)
                {
                    inventarioInicial.Valores[i] = Prod.InventarioInicial;
                }
                else
                {
                    inventarioInicial.Valores[i] = inventarioFinal.Valores[i - 1];
                }
                // demanda
                demanda.Valores[i] = ADemanda[i];
                // stock de seguridad
                stockSeguridad.Valores[i] = Prod.StockSeguridad;

                // prodRequerida
                produccionRequerida.Valores[i] = demanda.Valores[i] + stockSeguridad.Valores[i] - inventarioInicial.Valores[i];

                // inventario final
                inventarioFinal.Valores[i] = produccionRequerida.Valores[i] + inventarioInicial.Valores[i] - demanda.Valores[i];
            }

            double totalProduccionRequerida = produccionRequerida.sumaValores() * Prod.HorasRequeridas;
            double sumaDiasHabiles = ADiasHabiles.Sum() * 8;
            double hrsTrabajadas = Math.Round(totalProduccionRequerida / sumaDiasHabiles, 2);

            for (int i = 0; i < NumPeriodo; i++)
            {
                // horas disponibles
                hrsDisponibles.Valores[i] = ADiasHabiles[i] * 8 * hrsTrabajadas;
                // produccion real
                produccionReal.Valores[i] = Math.Round(hrsDisponibles.Valores[i] / prod.HorasRequeridas,2);
                // inv inicial
                if (i == 0)
                {
                    inventarioInicial.Valores[i] = Prod.InventarioInicial;
                }
                else
                {
                    inventarioInicial.Valores[i] = inventarioFinal.Valores[i - 1];
                }
                // demanda no cambia
                // inventario final
                inventarioFinal.Valores[i] = produccionReal.Valores[i] + inventarioInicial.Valores[i] - demanda.Valores[i];

                // costo faltante y de mantenimiento
                if (inventarioFinal.Valores[i] < 0)
                {
                    ctsFaltante.Valores[i] = Math.Abs(inventarioFinal.Valores[i]) * Prod.CostoFaltante;
                    ctsMant.Valores[i] = 0;
                }
                else
                {
                    ctsMant.Valores[i] = inventarioFinal.Valores[i] * Prod.CostoMantenimiento;
                    ctsFaltante.Valores[i] = 0;
                }
                // tiempoNormal
                tiempoNormal.Valores[i] = hrsDisponibles.Valores[i] * Prod.CostoHrs;

            }
            List<Fila> filas = new List<Fila>();
            filas.Add(produccionRequerida);
            filas.Add(hrsDisponibles);
            filas.Add(produccionReal);
            filas.Add(inventarioInicial);
            filas.Add(demanda);
            filas.Add(inventarioFinal);
            filas.Add(ctsFaltante);
            filas.Add(ctsMant);
            filas.Add(tiempoNormal);
            return filas;

            
        }



    }
}
