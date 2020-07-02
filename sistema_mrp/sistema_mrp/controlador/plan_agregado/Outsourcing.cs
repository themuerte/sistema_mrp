using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador.plan_agregado
{
    class Outsourcing
    {
        Producto prod;
        Empresa empresa;
        int numeroPeriodos;
        double[] demanda;
        double[] diasHabiles;
        double costoTotal = 0;

        public double[] ADemanda { get => demanda; set => demanda = value; }
        public double[] ADiasHabiles { get => diasHabiles; set => diasHabiles = value; }
        public Producto Prod { get => prod; set => prod = value; }
        public int NumPeriodo { get => numeroPeriodos; set => numeroPeriodos = value; }
        internal Empresa Empresa { get => empresa; set => empresa = value; }
        public double CostoTotal { get => costoTotal; set => costoTotal = value; }

        public Outsourcing(Producto prod, int numeroPeriodos)
        {
            if(numeroPeriodos > 12)
            {
                NumPeriodo = 12;
            }
            else
            {
                NumPeriodo = numeroPeriodos;
            }

            Prod = prod;
            Empresa = Empresa.GetEmpresa();
            ADemanda = PlanProducto.GetDemandaEstimadaByProducto(prod.IdProducto);
            ADiasHabiles = PlanAgregado.getDiasHabiles();
        }

        public Outsourcing(double[] aDemanda, double[] aDiasHabiles, Producto prod, int numPeriodo, Empresa empresa)
        {
            ADemanda = aDemanda;
            ADiasHabiles = aDiasHabiles;
            Prod = prod;
            NumPeriodo = numPeriodo;
            Empresa = empresa;
        }

        public List<Fila> getPlanAgregado()
        {
            CostoTotal = 0;
            Fila inventarioInicial, demanda, stockSeguridad,horasRequeridas, inventarioFinal, produccionRequerida, produccionReal, hrsDisponibles, unidFaltantes, ctsFaltantes, tiempoNormal;


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
            horasRequeridas = new Fila("Horas Requeridas");
            horasRequeridas.Valores = new double[NumPeriodo];
            unidFaltantes = new Fila("Unidades Faltantes");
            unidFaltantes.Valores = new double[NumPeriodo];
            ctsFaltantes = new Fila("Costos subcontratación");
            ctsFaltantes.Valores = new double[NumPeriodo];
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

            // obteniendo el mes de menor producción
            int indiceMenorProduccion = 0;
            double prodRequerida = produccionRequerida.Valores[0];
            for (int i = 0; i < NumPeriodo; i++)
            {
                if(prodRequerida >= produccionRequerida.Valores[i])
                {
                    indiceMenorProduccion = i;
                    prodRequerida = produccionRequerida.Valores[i];
                }
            }
            horasRequeridas.Valores[indiceMenorProduccion] = produccionRequerida.Valores[indiceMenorProduccion] * Prod.CostoHrs;
            double numTrabajadores = Math.Round(horasRequeridas.Valores[indiceMenorProduccion] / (ADiasHabiles[indiceMenorProduccion] * 8));
            for (int i = 0; i < NumPeriodo; i++)
            {
                // produccion requerida queda igual
                // horas requeridas
                horasRequeridas.Valores[i] = produccionRequerida.Valores[i] * Prod.CostoHrs;

                // horas disponibles
                hrsDisponibles.Valores[i] = ADiasHabiles[i] * 8 * numTrabajadores;

                // produccion real
                produccionReal.Valores[i] = Math.Round(hrsDisponibles.Valores[i] / Prod.HorasRequeridas, 2);

                // produccion Faltante
                unidFaltantes.Valores[i] = produccionRequerida.Valores[i] - produccionReal.Valores[i];

                // produccion subcontratacion
                ctsFaltantes.Valores[i] = unidFaltantes.Valores[i] * Empresa.CostoSubContratacion;

                // tiempo normal
                tiempoNormal.Valores[i] = hrsDisponibles.Valores[i] * Prod.CostoHrs;

            }
            List<Fila> filas = new List<Fila>();
            filas.Add(inventarioInicial);
            filas.Add(demanda);
            filas.Add(stockSeguridad);
            filas.Add(inventarioFinal);
            filas.Add(produccionRequerida);
            filas.Add(horasRequeridas);
            filas.Add(hrsDisponibles);
            filas.Add(produccionReal);
            filas.Add(unidFaltantes);
            filas.Add(ctsFaltantes);
            filas.Add(tiempoNormal);
            CostoTotal += ctsFaltantes.Valores.Sum();
            CostoTotal += tiempoNormal.Valores.Sum();
            return filas;
        }

    }
}
