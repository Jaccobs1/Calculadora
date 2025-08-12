using MaoNaMassa.Entities;

Produto produto = new Produto("Coca-cola 2L", 7.50M);
decimal valorConvertido;
bool desejaSair = false;

do
{
    Console.WriteLine($"Produto: {produto.Nome}\n" +
                  $"Preco  : {produto.Preco}\n");

    Console.WriteLine("1 - Alterar nome");
    Console.WriteLine("2 - Alterar preço");
    Console.WriteLine("3 - Exibir detalhes");
    Console.WriteLine("4 - Sair\n");

    Console.Write("Opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();

            Console.WriteLine("===ALTERAR_NOME_PRODUTO===\n");

            Console.Write("Nome: ");
            produto.AlterarNome(Console.ReadLine());
            break;
        case "2":
            Console.Clear();

            Console.WriteLine("===ALTERAR_PREÇO_PRODUTO===\n");

            Console.Write("Preço: ");
            decimal.TryParse(Console.ReadLine(), out valorConvertido);
            produto.AlterarPreco(valorConvertido);
            break;
        case "3":
            Console.Clear();

            Console.WriteLine("===EXIBIR_DETALHES_PRODUTO===\n");

            produto.ExibirDetalhes();
            break;
        case "4":
            desejaSair = true;
            break;
    }
} while (!desejaSair);