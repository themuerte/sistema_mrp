using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador.plan_agregado
{
    class EstrategiaPersecucion
    {
        double[] demanda;
        double[] diasHabiles;
        List<Fila> tabla;
        Producto p;
        Empresa e;
        int numeroPeriodos;
        public EstrategiaPersecucion(Producto p, int numeroPeriodos)
        {
            if(numeroPeriodos > 12 || numeroPeriodos <=0)
            {
                NumeroPeriodos = 12;
            }
            else
            {
                NumeroPeriodos = numeroPeriodos;
            }
            P = p;
            E = Empresa.GetEmpresa();
        }

        public Producto P { get => p; set => p = value; }
        public double[] Demanda { get => demanda; set => demanda = value; }
        public double[] DiasHabiles { get => diasHabiles; set => diasHabiles = value; }
        public int NumeroPeriodos { get => numeroPeriodos; set => numeroPeriodos = value; }
        internal Empresa E { get => e; set => e = value; }

        public List<Fila> getPlanAgregado()
        {
            /*filas a crear
            inventario inicial
            demanda
            stock de seguridad
            inventario final
            
            prod requerida
            hrs requeridas
            hrs disponibles
            
            trabajadores requeridos
            contrataciones numero
            contrataciones  dinero
            
            despidos numero
            despidos dinero

            tiempoNormal
             

             */
            Fila inventarioInicial, demanda, stockSeguridad, inventarioFinal, produccionRequerida, hrsRequeridas, hrsDisponibles, trabRequeridos, contratNum, contratCost, despidosNum, despidosCost, tiempoNormal;

            inventarioInicial = new Fila("Inventario inicial");
            inventarioInicial.Valores = new double[numeroPeriodos];
            demanda = new Fila("Demanda");
            demanda.Valores = new double[numeroPeriodos];
            stockSeguridad = new Fila("Stock de Seguridad");
            stockSeguridad.Valores = new double[numeroPeriodos];
            inventarioFinal = new Fila("Inventario Final");
            inventarioFinal.Valores = new double[numeroPeriodos];
            produccionRequerida = new Fila("Producción Requerida");
            produccionRequerida.Valores = new double[numeroPeriodos];
            hrsRequeridas = new Fila("Horas Requeridas");
            hrsRequeridas.Valores = new double[numeroPeriodos];
            hrsDisponibles = new Fila("Horas Disponibles");
            hrsDisponibles.Valores = new double[numeroPeriodos];
            trabRequeridos = new Fila("Trabajadores Requeridos");
            trabRequeridos.Valores = new double[numeroPeriodos];
            contratNum = new Fila("Número de contrataciones");
            contratNum.Valores = new double[numeroPeriodos];
            contratCost = new Fila("Costo de contrataciones");
            contratCost.Valores = new double[numeroPeriodos];
            despidosNum = new Fila("Número de despidos");
            despidosNum.Valores = new double[numeroPeriodos];
            despidosCost = new Fila("Costo de despidos");
            despidosCost.Valores = new double[numeroPeriodos];
            tiempoNormal = new Fila("Tiempo Normal");
            tiempoNormal.Valores = new double[numeroPeriodos];
            Demanda = PlanProducto.GetDemandaEstimadaByProducto(p.IdProducto);
            DiasHabiles = PlanAgregado.getDiasHabiles();
            int numerosTrabajadores =(int) e.FuerzaLaboral;
            for (int i = 0; i < numeroPeriodos; i++)
            {

                // inventario inicial
                if(i == 0)
                {
                    inventarioInicial.Valores[i] = p.InventarioInicial;
                }
                else
                {
                    inventarioInicial.Valores[i] = inventarioFinal.Valores[i - 1];
                }
                // demanda
                demanda.Valores[i] = Demanda[i];
                // stock de seguridad
                stockSeguridad.Valores[i] = p.StockSeguridad;

                // prodRequerida
                produccionRequerida.Valores[i] = demanda.Valores[i] + stockSeguridad.Valores[i] - inventarioInicial.Valores[i];

                // inventario final
                inventarioFinal.Valores[i] =produccionRequerida.Valores[i] + inventarioInicial.Valores[i] -  demanda.Valores[i];

                // horas requeridas
                hrsRequeridas.Valores[i] = produccionRequerida.Valores[i] * p.HorasRequeridas;

                // horas disponibles
                hrsDisponibles.Valores[i] = DiasHabiles[i] * 8;

                // trabajadores requeridos
                Decimal paso1 = new decimal(hrsRequeridas.Valores[i] / hrsDisponibles.Valores[i]);
                paso1 = Math.Floor(paso1); // redondear al mayor
                double paso2 = double.Parse(paso1.ToString());
                trabRequeridos.Valores[i] = paso2;


                // numero de trabajadores contratados y despedidos y sus costos
                if(numerosTrabajadores > trabRequeridos.Valores[i])
                {
                    int diferencia = numerosTrabajadores - (int)trabRequeridos.Valores[i];
                    numerosTrabajadores -= diferencia;

                    despidosNum.Valores[i] = diferencia;
                    despidosCost.Valores[i] = diferencia * e.CostoDespido;

                    contratNum.Valores[i] = 0;
                    contratCost.Valores[i] = 0;
                }
                else if(numerosTrabajadores < trabRequeridos.Valores[i])
                {
                    int diferencia = (int)trabRequeridos.Valores[i] - numerosTrabajadores;
                    numerosTrabajadores += diferencia;

                    contratNum.Valores[i] = diferencia;
                    contratCost.Valores[i] = diferencia * e.CostoContratacion;

                    despidosNum.Valores[i] = 0;
                    despidosCost.Valores[i] = 0;

                }
                else
                {
                    despidosNum.Valores[i] = 0;
                    despidosCost.Valores[i] = 0;

                    contratNum.Valores[i] = 0;
                    contratCost.Valores[i] = 0;
                }
                // costo tiempo en horas normales
                tiempoNormal.Valores[i] = hrsRequeridas.Valores[i] * p.CostoHrs;

            }
            List<Fila> filas = new List<Fila>();
            filas.Add(inventarioInicial);
            filas.Add(demanda);
            filas.Add(stockSeguridad);
            filas.Add(inventarioFinal);
            filas.Add(produccionRequerida);
            filas.Add(hrsRequeridas);
            filas.Add(hrsDisponibles);
            filas.Add(trabRequeridos);
            filas.Add(contratNum);
            filas.Add(contratCost);
            filas.Add(despidosNum);
            filas.Add(despidosCost);
            filas.Add(tiempoNormal);
            return filas;
        }
    }
}
