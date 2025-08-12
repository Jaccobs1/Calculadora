using System.Reflection.Metadata;
using System.Threading.Channels;

//string nome;
//int idade;
//double valor;
//float preco;
//decimal saldoConta;

//const string ddd = "";
//const int idadeMin = 18;

//Console.Write("Informe o dia q vc nasceu: ");
//string diaTexto = Console.ReadLine();
//Console.Write("Informe o mês q vc nasceu: ");
//string mesTexto = Console.ReadLine();
//Console.Write("Informe o ano q vc nasceu: ");
//string anoTexto = Console.ReadLine();

////Converte os valores
//int dia = int.Parse(diaTexto);
//int mes = int.Parse(mesTexto);
//int ano = int.Parse(anoTexto);

////Console.WriteLine("");
////Console.WriteLine($"Data de nascimento: ({dia}/{mes}/{ano})");

//DateTime data = new DateTime(ano, mes, dia);
//Console.WriteLine(data.ToString("(dd/MM/yyyy)"));

//Console.WriteLine($"5 + 7 = {5 + 7}");
//Console.WriteLine($"5 - 3 = {5 - 3}");
//Console.WriteLine($"10 * 2 = {10 * 2}");
//Console.WriteLine($"9 / 3 = {9.0 / 3.0}"); //Useu o ) para considerar o ponto flutuante
//Console.WriteLine($"10 % 3 = {10 % 3}");

//var resultado = 12.34 / 32.4;
//Console.WriteLine($"Resultado da divisão é: {resultado.ToString("F2")}"); //2 número depois da vírgula




// I AT1
//Console.Write("Informe o 1º número: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"A soma dos números é: {num1 + num2}");


// I AT2
//Console.Write("Informe o 1º número: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"A diferença entre os números é de: {num1 - num2}");


// I AT3
//Console.Write("Informe o 1º número: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"O produto é: {num1 * num2}");


// I AT4
//Console.Write("Informe o 1º número: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"O resultado da divisão é: {num1 / num2}");


// I AT5
//Console.Write("Informe o 1º número: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"O resto da divisão é: {num1 % num2}");




// II AT1
//int num;
//Console.Write("Digite um número: ");
//num = int.Parse(Console.ReadLine());
//Console.WriteLine($"O número digitado é: {num}");


// II AT2
//int num = 20;
//Console.Write("Informe um número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine($"O resultado é: {num += num2}");


// II AT3
//int num = 50;
//Console.Write("Informe um número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine($"O resultado é: {num - num2}");


// II AT4
//int num = 10;
//Console.Write("Informe um número: ");
//int num2 = int.Parse(Console.ReadLine());
//Consol
//e.WriteLine($"O resultado é: {num * num2}");

// II AT5
//int num = 30;
//Console.Write("Informe um número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine($"O resultado é: {num / num2}");




// III AT1
//Console.Write("Informe o 1º número: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"Os números são iguais? {num1 == num2}");


// III AT2
//Console.Write("Informe o 1º número? ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número? ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"Os números não são iguais? {num1 != num2}");


// III AT3
//Console.Write("Informe o 1º número? ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número? ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"O 1º número é maior q o 2º? {num1 > num2}");


// III AT4
//Console.Write("Informe o 1º número? ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número? ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"O 1º número é menor q o 2º? {num1 < num2}");


// III AT5
//Console.Write("Informe o 1º número? ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número? ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"O 1º número é maior ou igual ao 2º? {num1 >= num2}");




// IIII AT1
//Console.Write("informe o 1º número? ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("informe o 2º número? ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"os números são maiores q 0? {num1 > 0 && num2 > 0}");


// IIII AT2
//Console.Write("Informe o 1º número? ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Informe o 2º número? ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"ALgum número é maior q 0? {num1 < 0 || num2 < 0}");




// IIIII AT1
//Console.Write("Informe sua idade: ");
//int idade = int.Parse(Console.ReadLine());s
//Console.WriteLine("");
//Console.WriteLine($"{(idade >= 18 ? "Maior de idade" : "Menor de idade")}");


// IIIII AT2
//Console.Write("Informe um número? ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"O número é {(num % 2 == 0 ? "PAR" : "IMPAR")}");


// IIIII AT3
//Console.Write("Informe um número? ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine($"O número é {(num > 0 ? "POSITIVO" : num < 0 ? "NEGATIVO" : "ZERO")}");




// MÃO NA MASSA IF-ELSE
//ConsoleApp1.MaosNaMassa.PraticaIfElse.Executar();

// MÃO NA MASSA SWITCH
//ConsoleApp1.MaosNaMassa.PraticaSwitch.Executar();

// MÃO NA MASSA ARRAY[]
//ConsoleApp1.MaosNaMassa.PraticaArray.Executar();

// MÃO NA MASSA List<>
//ConsoleApp1.MaosNaMassa.PraticaList.Executar();

//MÃO NA MASSA FOR
//ConsoleApp1.MaosNaMassa.PraticaFor.Executar();

// MÃO NA MASSA WHILE
//ConsoleApp1.MaosNaMassa.PraticaWhile.Executar();

// MÃO NA MASSA DO-WHILE
//ConsoleApp1.MaosNaMassa.PraticaDoWhile.Executar();

// MÃO NA MASSA FOREACH
//ConsoleApp1.MaosNaMassa.PraticaForeach.Executar();




//INSTRUÇÃO IF AT1
//Console.Write("Informe um número: ");
//double num = double.Parse(Console.ReadLine());
//double sobra = num % 2;
//Console.WriteLine("");

//if (sobra == 0)
//{
//    Console.WriteLine("O número é par.");
//}
//else
//{
//    Console.WriteLine("O número é impar.");
//}


// AT2
//Console.Write("Informe seu nome: ");
//string nome = Console.ReadLine();
//Console.Write("Informe sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//if (idade < 18 || idade > 60)
//{
//    Console.WriteLine("Você não pode entrar por motivos de segurança.");
//}
//else
//{
//    Console.WriteLine("Seja bem vindo :)");
//}




// INSTRUÇÃO SWITCH
//char num = 'a';
//do
//{
//    if (num != 'a')
//    {
//        Console.WriteLine("Número inválido !!!\n");
//    }

//    Console.Write("Informe um número de 1 a 7: ");
//    num = char.Parse(Console.ReadLine());
//    Console.Clear();
//} while (num != '1'  && num != '2' && num != '3' && num != '4' && num != '5' && num != '6' && num != '7');


//switch (num)
//{
//    case '1':
//        Console.WriteLine("Domingo");
//        break;
//    case '2':
//        Console.WriteLine("Segunda-feira");
//        break;
//    case '3':
//        Console.WriteLine("Terça-feira");
//        break;
//    case '4':
//        Console.WriteLine("Quarta-feira");
//        break;
//    case '5':
//        Console.WriteLine("Quinta-feira");
//        break;
//    case '6':
//        Console.WriteLine("Sexta-feira");
//        break;
//    case '7':
//        Console.WriteLine("Sabado");
//        break;
//    default:
//        Console.WriteLine("Número inválido!");
//        break;
//}




// ARRAYS AT1
//double[] numeros = new double[5];
//double soma = 0;

//for (int i = 0; i <= 4; ++i)
//{
//    Console.Write($"Informe o {i + 1}º número: ");
//    numeros[i] = double.Parse(Console.ReadLine());
//    soma = soma + numeros[i];
//}

//Console.WriteLine("");
//Console.WriteLine($"A soma é: {soma}");


// AT2
//double[] numeros = new double[10];
//double max = double.MinValue, min = double.MaxValue;

//for (int i = 0; i <= numeros.Length; ++i)
//{
//    Console.Write($"Informe o {i + 1}º número: ");
//    numeros[i] = double.Parse(Console.ReadLine());
//}

//foreach (int num in numeros)
//{
//    if (num > max)
//    {
//        max = num;
//    }
//    if (num < min)
//    {
//        min = num;
//    }
//}

//Console.WriteLine("");
//Console.WriteLine($"O maior número é: {max}");
//Console.WriteLine($"O menor número é: {min}");


// AT3
//string[] nomes = new string[5];

//for (int i = 0; i <= 4; ++i)
//{
//    Console.Write($"Informe o {i + 1}º nome: ");
//    nomes[i] = Console.ReadLine();
//}
//Console.WriteLine("");

//for (int i = nomes.Length; i >= 0; --i)
//{
//    Console.WriteLine(nomes[i]);
//}




// LISTAS AT1
//List<string> nomes = new List<string>(0);
//string nome;
//int i = 1;

//Console.WriteLine("Digite 0 para encerrar");
//Console.WriteLine("Informe os nomes\n");

//do
//{
//    Console.Write($"{i}º nome: ");
//    nome = Console.ReadLine();
//    if (nome != "0")
//    {
//        nomes.Add(nome);
//        i++;
//    }
//} while (nome != "0");

//Console.WriteLine();

//foreach (var item in nomes)
//{
//    Console.WriteLine(item);
//}


// AT2
//List<int> numeroSort = new List<int>() { 10, 21, 43, 89, 64, 75, 91, 7, 27, 39 };
//const int NUMERO_TENTATIVAS = 3;
//Console.WriteLine("");
//bool ehCerto = false;

//Console.WriteLine("INFORME O NÚMERO CORRETO (3 TENTATIVAS)");
//Console.WriteLine();

//for (int i = 0; i < NUMERO_TENTATIVAS; ++i)
//{
//    int num = 0;
//    if (ehCerto == false)
//    {
//        Console.Write($"{i + 1}ª tentativa: ");
//        num = int.Parse(Console.ReadLine());
//    }

//    foreach (var item in numeroSort)
//    {
//        if (num == item)
//        {
//            Console.WriteLine();
//            Console.WriteLine("Parabens, você acertou um dos número da sorte :)");
//            ehCerto = true;
//        }
//    }
//}

//if (ehCerto == false)
//{
//    Console.WriteLine();
//    Console.WriteLine("Você não acertou nenhum número da sorte!");
//}




// INSTRUÇÃO FOR AT1
//Console.Write("Informe um número positivo: ");
//int entrada = int.Parse(Console.ReadLine());
//int num = entrada;

//for (int i = (num - 1); i > 0; i--)
//{
//    num = (num * i);
//}
//Console.WriteLine();
//Console.WriteLine($"O fatorial de {entrada} é: {num}");


// AT2
//Console.Write("Informe um número: ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine();

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"{num} X {i + 1} = {num * (i + 1)}");
//}




// INSTRUÇÃO DO-WHILE AT1
//var numeros = new List<int>();
//int entrada = 0, numero = 0, resultado = 0;
//int i = 1;

//Console.WriteLine("Digite um número negativo para encerrar\n");

//while (entrada >= 0)
//{
//    Console.Write($"Informe o {i}º número: "); i++;
//    entrada = int.Parse(Console.ReadLine());
//    if (entrada >= 0)
//    {
//        numeros.Add(entrada);
//    }
//}

//foreach (var num in numeros)
//{
//    resultado = resultado + num;
//}

//Console.WriteLine();
//Console.WriteLine($"A soma dos números é: {resultado}");


// AT2
//int entrada = 1, contador = 0, i = 1;
//var numerosPositivos = new List<int>();

//Console.WriteLine("Digite 0 para encerrar\n");

//while (entrada != 0)
//{
//    Console.Write($"Informe o {i}º número: "); i++;
//    entrada = int.Parse(Console.ReadLine());

//    if (entrada % 2 == 0 && entrada != 0)
//    {
//        contador++;
//    }
//}

//Console.WriteLine();
//Console.WriteLine($"{contador} números pares forma digitados");




// INSTRUÇÃO FOREACH
//var nomes = new List<string>() { "Jonas", "Luana", "Matheus", "Marco", "Jorge" };

//foreach (var nome in nomes)
//{
//    Console.WriteLine(nome);
//}




// INSTRUÇÃO DO-WHILE
string entrada = "";
decimal saldo = 53;
bool desejaSair = false, desejaRepetir = false;

while (!desejaSair)
{
    do
    {
        Console.Clear();
        Console.WriteLine("Banco +Devs2Blu, seja bem vindo!\n");
        Console.WriteLine("1 - Consultar saldo");
        Console.WriteLine("2 - Realizar depósito");
        Console.WriteLine("3 - Realizar saque");
        Console.WriteLine("4 - Sair\n");

        Console.Write("Opção: ");
        entrada = Console.ReadLine();
    } while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4");
    Console.Clear();

    if (entrada == "1")
    {
        string opcao = "";
        do
        {
            Console.Clear();
            Console.WriteLine($"Seu saldo é de: {saldo}\n");

            Console.WriteLine("1 - Voltar");
            Console.WriteLine("2 - Sair");

            Console.Write("\nOpção: ");
            opcao = Console.ReadLine();
        } while (opcao != "1" && opcao != "2");

        if (opcao == "2")
        {
            desejaSair = true;
        }
    }
    else if (entrada == "2")
    {
        desejaRepetir = true;
        while (desejaRepetir)
        {
            string opcao = "";
            desejaRepetir = false;
            bool converteu = true;
            decimal valor;

            do
            {
                if (!converteu)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido!!!");
                }

                Console.WriteLine($"Saldo: {saldo}\n");
                Console.Write("Informe um valor para depósito: ");
                Console.Write("Informe um valor para depósito: ");
                converteu = decimal.TryParse(Console.ReadLine(), out valor);

                if (valor < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Não é possivel fazer um depósito com número negativo ou zero!!!");
                }
                else
                {
                    saldo = saldo + valor;
                }
            } while (!converteu);

            do
            {
                Console.WriteLine($"\nSaldo atualizado: {saldo}\n");

                Console.WriteLine("1 - Outro depósito");
                Console.WriteLine("2 - Voltar");
                Console.WriteLine("3 - Sair");

                Console.Write("\nOpção: ");
                opcao = Console.ReadLine();
                Console.Clear();
            } while (opcao != "1" && opcao != "2" && opcao != "3");

            if (opcao == "1")
            {
                desejaRepetir = true;
                Console.Clear();
            }
            if (opcao == "3")
            {
                desejaSair = true;
            }
        }
    }
    else if (entrada == "3")
    {
        desejaRepetir = true;
        while (desejaRepetir)
        {
            string opcao = "";
            desejaRepetir = false;
            bool converteu = true;
            decimal valor;

            do
            {
                if (!converteu)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido!!!");
                }

                Console.WriteLine($"Saldo: {saldo}\n");
                Console.Write("Informe um valor para Saque: ");
                converteu = decimal.TryParse(Console.ReadLine(), out valor);


            } while (!converteu);

            while (valor > saldo)
            {
                Console.Clear();
                Console.WriteLine("Saldo insuficiente!!!");
                Console.WriteLine($"Saldo: {saldo}\n");
                Console.Write("Informe um valor para saque: ");
                converteu = decimal.TryParse(Console.ReadLine(), out valor);
            }

            if (valor < 0)
            {
                Console.WriteLine("Não é possivel sacar um valor negativo!!!");
            }
            else
            {
                saldo = saldo - valor;
            }
            
            Console.WriteLine($"\nSaldo atualizado: {saldo}\n");

            do
            {
                Console.WriteLine("1 - Outro Saque");
                Console.WriteLine("2 - Voltar");
                Console.WriteLine("3 - Sair");

                Console.Write("\nOpção: ");
                opcao = Console.ReadLine();
                Console.Clear();
            } while (opcao != "1" && opcao != "2" && opcao != "3");

            if (opcao == "1")
            {
                desejaRepetir = true;
                Console.Clear();
            }
            if (opcao == "3")
            {
                desejaSair = true;
            }
        }
    }
    else
    {
        desejaSair = true;
    }
    Console.Clear();
}