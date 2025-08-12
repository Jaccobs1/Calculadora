using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MaosNaMassa
{
    internal class PraticaDoWhile
    {
        public static void Executar()
        {
            const string SENHA = "bolinha";
            string entrada = "";

            do
            {
                if (entrada != "")
                {
                    Console.WriteLine("Senha incorreta!\n");
                }

                Console.Write("Digite a senha: ");
                entrada = Console.ReadLine().ToLower();
                Console.Clear();
            } while (entrada != SENHA);

            Console.WriteLine("Login efetuado :)");
        }
    }
}
