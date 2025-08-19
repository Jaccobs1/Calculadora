using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operações
{
    internal class Divisao
    {
        public static double Dividir(double n1, double n2)
        {
           if (n2 == 0)
            {
                return double.NaN;
            }
           return n1 / n2;
        }
    }
}
