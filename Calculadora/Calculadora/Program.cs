using Calculadora.Operações;
using Calculadora.Utils;

string opcao = "";
double n1, n2,resultado;
bool sair = false;

do
{
        Console.Clear();
        Console.WriteLine("CALCULADORA\n");

        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Radiciação");
        Console.WriteLine("0 - SAIR\n");

        Console.Write("Opção: ");
        opcao = Console.ReadLine();

    Console.Clear();

    switch (opcao)
    {
        case "0":
            sair = true;
            break;
        case "1":
            Console.Write("1º número: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.Write("2º número: ");
            double.TryParse(Console.ReadLine(), out n2);

            resultado = Adicao.Somar(n1, n2);

            Console.WriteLine($"\nResultado: {resultado}");
            Console.ReadKey();
            break;
        case "2":
            Console.Write("1º número: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.Write("2º número: ");
            double.TryParse(Console.ReadLine(), out n2);

            resultado = Subtracao.Subtrair(n1, n2);

            Console.WriteLine($"\nResultado: {resultado}");
            Console.ReadKey();
            break;
        case "3":
            Console.Write("1º número: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.Write("2º número: ");
            double.TryParse(Console.ReadLine(), out  n2);

            resultado = Multiplicacao.Multiplicar(n1, n2);

            Console.WriteLine($"\nResultado: {resultado}");
            Console.ReadKey();
            break;
        case "4":
            Console.Write("1º número: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.Write("2º número: ");
            double.TryParse(Console.ReadLine(), out n2);

            resultado = Divisao.Dividir(n1,n2);

            Console.WriteLine($"\nResultado: {resultado}");
            Console.ReadKey();
            break;
        case "5":
            Console.Write("Insira o radicando: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.Write("Insira o índice (ex: 2 para raíz quadrada): ");
            double.TryParse(Console.ReadLine(), out n2);

            resultado = Raiz.Radiciacao(n1, n2);

            Console.WriteLine($"\nResultado: {resultado}");
            Console.ReadKey();
            break;
        default:
            ConsoleUtils.MensagemErro();
            break;
    }
} while (!sair);

ConsoleUtils.MensagemSaida();