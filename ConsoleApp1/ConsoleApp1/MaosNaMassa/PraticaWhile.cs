using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MaosNaMassa
{
    internal class PraticaWhile
    {
        public static void Executar()
        {
            var entrada = "";
            int max = int.MinValue, min = int.MaxValue;
            int i = 0;

            Console.WriteLine("DIGITE \"OK\" PARA ENCERRAR\n");

            while (entrada.ToLower() != "ok")
            {
                Console.Write($"Informe o {i + 1}º número: ");
                entrada = (Console.ReadLine());
                int num = 0;
                if (entrada.ToLower() != "ok")
                {
                    num = int.Parse(entrada);
                    if (num > max)
                    {
                        max = num;
                    }
                    else if (num < min)
                    {
                        min = num;
                    }
                }
                i++;
            }

            Console.WriteLine();
            Console.WriteLine($"O maior número é {max} \n" +
                $"O menor número é {min}");
        }
    }
}
