using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_mrp.controlador
{
   public class Fila
    {
        string nombreFila;
        double[] valores;

        public Fila(string nombreFila)
        {
            NombreFila = nombreFila;
        }

        public double[] Valores { get => valores; set => valores = value; }
        public string NombreFila { get => nombreFila; set => nombreFila = value; }

        public double sumaValores()
        {
            double suma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                suma += Valores[i];
            }
            return suma;
        }
    }
}
