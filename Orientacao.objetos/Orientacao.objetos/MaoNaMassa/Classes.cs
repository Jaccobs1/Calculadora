using Orientacao.objetos.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.objetos.MaoNaMassa
{
    public class Classes
    {
        // ALUNO
        //public static void Executar()
        //{
        //    Aluno aluno = new Aluno("Jonas", "95655468435", 22);

        //    Console.WriteLine("Informarções do aluno\n");
        //    Console.WriteLine($"Nome: {aluno.Nome}");
        //    Console.WriteLine($"Matrícula: {aluno.Matricula}");
        //    Console.WriteLine($"Idade: {aluno.Idade}");
        //}

        // CONTA BANCARIA
        public static void Executar()
        {
            string opcao = "";
            bool desejaSair = false;
            CultureInfo brazilianCulture = new CultureInfo("pt-BR");


            new ContaBancaria("Jonas", 5000);
            new ContaBancaria("Joel", 1000);
            new ContaBancaria("Diego", 2500);

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("<---- MAZE BANK ---->\n");

                    Console.WriteLine($"Total de contas cadastradas: R${ContaBancaria.Contador}");
                    Console.WriteLine($"Saldo total de todas as contas: R${ContaBancaria.SaldoTotal.ToString("N", brazilianCulture)}\n");

                    Console.WriteLine("1 - Cadastrar conta");
                    Console.WriteLine("2 - Empréstimo");
                    Console.WriteLine("3 - Sair");

                    Console.Write("\nOpção: ");
                    opcao = Console.ReadLine();

                    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
                    {
                        Console.WriteLine("Opcção inválida!!!");
                        Thread.Sleep(500);
                    }

                } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4");

                if (opcao == "1")
                {
                    bool validou = false;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Cadastrar conta\n");

                        Console.Write("Nome: ");
                        string entradaNome = Console.ReadLine();
                        Console.Write("Saldo inicial: ");
                        bool converteu = decimal.TryParse(Console.ReadLine(), out decimal saldoInicial);

                        if (!converteu || entradaNome == "")
                        {
                            Console.WriteLine("\nNome ou saldo inicial inválido!!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            var conta = new ContaBancaria(entradaNome, saldoInicial);
                            validou = true;
                        }
                    } while (!validou);
                }
                else if (opcao == "2")
                {

                }
                else
                {
                    desejaSair = true;
                }
            } while (!desejaSair);
        }

        // PRODUTO
        //public static void Executar()
        //{
        //    Console.Write("Informe o nome do produto: ");
        //    string entradaNome = Console.ReadLine();
        //    Console.Write("Informe o preço do produto: ");
        //    string entradaPreco = Console.ReadLine();
        //    double.TryParse(entradaPreco, out double preco);

        //    var produto = new Produto(entradaNome, preco);

        //    Console.WriteLine($"\nO Valor do produto é: {Produto.CadastrarProduto(produto.Preco, true)}");
        //}
    }
}
