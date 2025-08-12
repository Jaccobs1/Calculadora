using Orientacao.objetos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Orientacao.objetos.MaoNaMassa
{
    internal class PraticaClasse
    {
        //public static void Executar()
        //{
        //    Animal animal = new Animal();
        //    animal.Nome = "Cavalo";
        //    animal.NomeCientifico = "Caballus";
        //    animal.Idade = 7;

        //    animal.Movimentar(75);
        //}

        //public static void Executar()
        //{
        //    Livro livro = new Livro("Harry Potter", "JK Rowling", 389);

        //    int paginaAtual = 0;

        //    while (paginaAtual != livro.QuantidadePaginas)
        //    {
        //        paginaAtual = livro.Ler();
        //        Console.WriteLine($"Página: {paginaAtual}");
        //        Thread.Sleep(300);
        //    }
        //}

        //public static void Executar()
        //{
        //    Calculadora calculadora = new Calculadora();
        //    string entrada = "";

        //    do
        //    {
        //        Console.WriteLine("===CALCULADORA===\n");
        //        Console.WriteLine("1 - Adição");
        //        Console.WriteLine("2 - Subtração");
        //        Console.WriteLine("3 - Multiplicação");
        //        Console.WriteLine("4 - Divisão");

        //        Console.Write("\nOpção: ");
        //        entrada = Console.ReadLine();

        //        if (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4")
        //        {
        //            Console.Clear();
        //            Console.WriteLine("\nValor inválido!");
        //            Thread.Sleep(1000);
        //            Console.Clear();
        //        }
        //    } while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4");

        //    switch (entrada)
        //    {
        //        case "1":
        //            Console.Clear();

        //            Console.WriteLine("===ADIÇÃO===\n");

        //            Console.Write($"Informe o {1}º número: ");
        //            bool converteu = double.TryParse(Console.ReadLine(), out double num1);
        //            Console.Write($"Informe o {2}º número: ");
        //            converteu = double.TryParse(Console.ReadLine(), out double num2);

        //            double resultado = calculadora.Somar(num1, num2);

        //            Console.WriteLine($"\nO resultado da soma é: {resultado}");
        //            break;
        //        case "2":
        //            Console.Clear();

        //            Console.WriteLine("===SUBTRAÇÃO===\n");

        //            Console.Write($"Informe o {1}º número: ");
        //            converteu = double.TryParse(Console.ReadLine(), out num1);
        //            Console.Write($"Informe o {2}º número: ");
        //            converteu = double.TryParse(Console.ReadLine(), out num2);

        //            resultado = calculadora.Subtrair(num1, num2);

        //            Console.WriteLine($"\nO resultado da subtração é: {resultado}");
        //            break;
        //        case "3":
        //            Console.Clear();

        //            Console.WriteLine("===MULTIPLICAÇÃO===\n");

        //            Console.Write($"Informe o {1}º número: ");
        //            converteu = double.TryParse(Console.ReadLine(), out num1);
        //            Console.Write($"Informe o {2}º número: ");
        //            converteu = double.TryParse(Console.ReadLine(), out num2);

        //            resultado = calculadora.Multiplicar(num1, num2);

        //            Console.WriteLine($"\nO resultado da multiplicação é: {resultado}");
        //            break;
        //        case "4":
        //            Console.Clear();

        //            Console.WriteLine("===DIVISÃO===\n");

        //            Console.Write($"Informe o {1}º número: ");
        //            converteu = double.TryParse(Console.ReadLine(), out num1);
        //            Console.Write($"Informe o {2}º número: ");
        //            converteu = double.TryParse(Console.ReadLine(), out num2);

        //            resultado = calculadora.Dividir(num1, num2);

        //            Console.WriteLine($"\nO resultado da divisão é: {resultado}");
        //            break;
        //    }
        //}
    }
}