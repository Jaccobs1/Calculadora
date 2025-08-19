using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utils
{
    public class ConsoleUtils
    {
        public static void MensagemErro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida!!!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Console.Clear();
        }

        public static void MensagemSaida()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("SAINDO");
            Thread.Sleep(250);
            Console.Write("*");
            Thread.Sleep(250);
            Console.Write("*");
            Thread.Sleep(250);
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
