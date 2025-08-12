using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MaosNaMassa
{
    internal class PraticaForeach
    {
        public static void Executar()
        {
            List<string> alunos = new List<string>();
            string entrada;
            int i = 1;

            Console.WriteLine("Digite 0 para encerrar\n");

            do
            {
                Console.Write($"Informe o {i}º aluno: ");
                entrada = Console.ReadLine();
                if (entrada != "0")
                {
                    alunos.Add(entrada);
                }
                i++;
            } while (entrada != "0");
            i = 1;
            Console.Clear();

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{i}º aluno: {aluno}");
                i++;
            }
        }
    }
}
