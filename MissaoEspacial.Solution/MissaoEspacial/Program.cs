using MissaoEspacial;
using MissaoEspacial.Entities;

List<Astronauta> astronautas = new List<Astronauta>();
string opcao;
bool DesejaSair = false;

astronautas.Add(new Astronauta("Roger", new DateTime(1990, 08, 02), "Brasil"));
astronautas.Add(new Astronauta("Aroldo", new DateTime(2000, 02, 24), "Inglaterra"));
astronautas.Add(new Astronauta("Marco", new DateTime(1997, 10, 15), "Rússia"));
astronautas.Add(new Astronauta("Craudio", new DateTime(1989, 01, 27), "Brasil"));
astronautas.Add(new Astronauta("Lawson", new DateTime(1992, 08, 22), "Estados unidos"));


do
{
    do
    {
        Console.WriteLine("===ESTAÇÃO_ESPACIAL_+DEVS2BLU===");
        Console.WriteLine($"Astronautas Cadastrados: {astronautas.Count}\n");

        Console.WriteLine("1 - Cadastrar astronauta");
        Console.WriteLine("2 - Realizar lançamento");
        Console.WriteLine("3 - Sair");

        Console.Write("\nOpcão: ");
        opcao = Console.ReadLine();

        if (opcao != "1" && opcao != "2" && opcao != "3")
        {
            Console.WriteLine("Opção inválida!!!");
            Thread.Sleep(500);
        }

        Console.Clear();
    } while (opcao != "1" && opcao != "2" && opcao != "3");

    switch (opcao)
    {
        case "1":
            Console.WriteLine("===CADASTRAR_AUSTRONAUTA===\n");

            Console.Write("Nome: ");
            string nomeEntrada = Console.ReadLine();
            Console.Write("Ano nascimento: ");
            int anoEntrada = int.Parse(Console.ReadLine());
            Console.Write("Mês nascimento: ");
            int mesEntrada = int.Parse(Console.ReadLine());
            Console.Write("Dia nascimento: ");
            int diaEntrada = int.Parse(Console.ReadLine());
            Console.Write("País: ");
            string paisEntrada = Console.ReadLine();

            DateTime dataNascimento = new DateTime(anoEntrada, mesEntrada, diaEntrada);
            Astronauta astronauta = new Astronauta(nomeEntrada, dataNascimento, paisEntrada);
            astronautas.Add(astronauta);

            Console.Clear();
            break;
        case "2":
            List<Astronauta> astronautasSelecionados = new List<Astronauta>();

            Console.WriteLine("===REALIZAR_LANÇAMENTO===\n");

            Console.Write("Nome Missão: ");
            string entradaNomeMissao = Console.ReadLine();
            Console.Write("Dias de missão: ");
            string entradaDiasMissao = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("ASTRONAUTAS_CADASTRADOS\n");
            for (int i = 0; i < astronautas.Count; i++)
            {
                Console.WriteLine($"{i+1} - {astronautas[i].Nome} : {astronautas[i].DataNascimento} : {astronautas[i].PaisOrigem}");
            }

            Console.WriteLine("");
            string opcaoAstronauta;
            int codigoAstronautaSelecionado = 0;

            do
            {
                Console.Write("Informe o código do astronauta: ");
                opcaoAstronauta = Console.ReadLine();
                int.TryParse(opcaoAstronauta, out int valor);
                codigoAstronautaSelecionado = valor;

                if ((codigoAstronautaSelecionado > astronautas.Count && codigoAstronautaSelecionado != 0) || (codigoAstronautaSelecionado <= 0 && codigoAstronautaSelecionado != 0))
                {
                    Console.WriteLine("Código Inexisteste !!!");
                    Thread.Sleep(500);
                }
                else
                {
                    astronautasSelecionados.Add(astronautas[codigoAstronautaSelecionado]);
                }

            } while (opcaoAstronauta != "0");

            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            DesejaSair = true;
            break;
    }
} while (!DesejaSair);


//DateTime data = new DateTime(1990, 08, 02);
//data.ToString("dd/MM/yyyy");
//PaisOrigem paisOrigem = new PaisOrigem();

