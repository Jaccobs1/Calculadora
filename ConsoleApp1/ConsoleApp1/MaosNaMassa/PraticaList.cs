using ConsoleApp1.MaosNaMassa.Objeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MaosNaMassa
{
    internal class PraticaList
    {
        public static void Executar()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i <= 4; ++i)
            {
                Pessoa pessoa = new Pessoa();
                Console.WriteLine($"{i + 1}º Aluno");
                Console.Write("Nome: ");
                pessoa.Nome = Console.ReadLine();
                Console.Write("Nota: ");
                pessoa.Nota = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                pessoas.Add(pessoa);
            }

            Console.Clear();
            Console.WriteLine("NOTAS DOS ALUNOS");
            Console.WriteLine("");
            Console.WriteLine("=-=-=-=-=-=-=-=-=--=-=");

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome} : {pessoa.Nota.ToString("F1")}");
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=--=-=");
        }
    }
}
