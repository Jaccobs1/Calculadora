using Calculadora.Operações;
using Calculadora.Utils;

string opcao = "";
bool sair = false;

do
{
    do
    {
        Console.Clear();

        Console.WriteLine("CALCULADORA\n");

        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("0 - SAIR\n");

        Console.Write("Opção: ");
        opcao = Console.ReadLine();

        if (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
        {
            ConsoleUtils.MensagemErro();
        }

    } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "0");

    Console.Clear();

    switch (opcao)
    {
        case "0":
            sair = true;
            break;
        case "1":
            Console.Write("1º número: ");
            double.TryParse(Console.ReadLine(), out double n1);
            Console.Write("2º número: ");
            double.TryParse(Console.ReadLine(), out double n2);

            double resultado = Adicao.Somar(n1, n2);

            Console.WriteLine($"\nResultado: {resultado}");
            Console.ReadKey();
            break;
        case "2":
            break;
        case "3":
           break;
        case "4":
            break;
    }
} while (!sair);
