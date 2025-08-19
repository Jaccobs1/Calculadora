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
            try
            {
                //Tentativa de executar a divisão
                //Se o numero 2 for zero, uma exceção vai ser lançada
                return n1 / n2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");

                return double.NaN;
            }
        }
    }
}
