using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calcolatrice
    {
        public static float Somma(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        public static float Sottrazione(float numero1, float numero2)
        {
            return numero1 - numero2;
        }

        public static float Moltiplicazione(float numero1, float numero2)
        {
            return numero1 * numero2;
        }

        public static float Divisione(float numero1, float numero2)
        {
            if (numero2 == 0)
            {
                throw new ArgumentException("Impossibile dividere per zero.");
            }
            return numero1 / numero2;
        }
    }
}
