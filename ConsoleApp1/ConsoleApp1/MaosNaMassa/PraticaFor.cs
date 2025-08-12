using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MaosNaMassa
{
    internal class PraticaFor
    {
        public static void Executar()
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"{num} x {i + 1} = {num * (i + 1)}");
            }
        }
    }
}
