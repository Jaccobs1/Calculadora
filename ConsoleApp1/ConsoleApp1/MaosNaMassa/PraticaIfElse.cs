using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MaosNaMassa
{
    internal class PraticaIfElse
    {
        public static void Executar()
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            string nomeMin = nome.ToLower();
            Console.WriteLine("");

            if (nomeMin == "ana" || nomeMin == "maria" || nomeMin == "joão" || nomeMin == "josé" || nomeMin == "carlos")
            {
                Console.WriteLine($"Pode entrar {nome}");
            }
            else
            {
                Console.WriteLine($"Desculpe {nome}, mas seu nome não está na lista");
            }
        }
    }
}
