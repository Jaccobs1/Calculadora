using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MaosNaMassa
{
    internal class PraticaArray
    {
        public static void Executar()
        {
            string[] nomes = new string[5];
            double[] notas = new double[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{i + 1}º ALUNO");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Nota: ");
                notas[i] = double.Parse(Console.ReadLine());
                while (notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("A nota deve ser entre 0 e 10");
                    Console.Write("Nota: ");
                    notas[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("");
            }

            Console.WriteLine("NOTAS DE ALUNOS");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=");

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{nomes[i]}: {notas[i].ToString("F1")}");
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
        }
    }
}
