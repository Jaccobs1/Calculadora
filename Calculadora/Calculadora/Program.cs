using Calculadora.Utils;

string opcao = "";

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

} while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4");

switch (opcao)
{
    case "1":
        break;
    case "2":
        break;
    case "3":
        break;
    case "4":
        break;
}