using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operações
{
    internal class Multiplicacao
    {
        public double N1;
        public double N2;

        public Multiplicacao(double primeiroNumero, double segundoNumero)
        {
            N1 = primeiroNumero;
            N2 = segundoNumero;
        }
        public void Multiplicar()
        {
            double resultadoMultiplicacao = N1 * N2;
        }

    }
}
