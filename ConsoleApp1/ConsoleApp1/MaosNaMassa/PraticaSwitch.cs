using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1.MaosNaMassa
{
    internal class PraticaSwitch
    {
        public static void Executar()
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            string nomeMai = nome.ToUpper();
            Console.WriteLine("");

            switch (nomeMai[0])
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                    Console.WriteLine($"{nome}, Você está na fila 2.");
                    break;
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    Console.WriteLine($"{nome}, Você está na fila 1.");
                    break;
                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    Console.WriteLine($"{nome}, Você está na fila 3.");
                    break;
                default:
                    Console.WriteLine("Nome inválido!");
                    break;
            }
        }
    }
}
