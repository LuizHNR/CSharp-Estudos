// Screen Sound
string mensagemDeBoasVindas = "Boas vindas GuruGuru";

//Lista <tipo> nomeDaLista
//List<string> listaBandas = new List<string> { "U2", "The Beatles" };

//Dicionario
Dictionary<string, List<float>> bandasRegistradas = new Dictionary<string, List<float>>();
bandasRegistradas.Add("Linkin Parck", new List<float> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<float>());

//void é uma função q não devolve nada, sem return
void ExibirLogo()
{
    //@ é o Verbatim Literal que é colocar a string do jeito q vc quer q apareça
    Console.WriteLine(@"
    
░██████╗░██╗░░░██╗██████╗░██╗░░░██╗░██████╗░██╗░░░██╗██████╗░██╗░░░██╗
██╔════╝░██║░░░██║██╔══██╗██║░░░██║██╔════╝░██║░░░██║██╔══██╗██║░░░██║
██║░░██╗░██║░░░██║██████╔╝██║░░░██║██║░░██╗░██║░░░██║██████╔╝██║░░░██║
██║░░╚██╗██║░░░██║██╔══██╗██║░░░██║██║░░╚██╗██║░░░██║██╔══██╗██║░░░██║
╚██████╔╝╚██████╔╝██║░░██║╚██████╔╝╚██████╔╝╚██████╔╝██║░░██║╚██████╔╝
░╚═════╝░░╚═════╝░╚═╝░░╚═╝░╚═════╝░░╚═════╝░░╚═════╝░╚═╝░░╚═╝░╚═════╝░
");

    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 para registra uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    // ! para nn retornar um valor nulo
    // RedeLine é o input
    string opcaoEscolida = Console.ReadLine()!;

    // Transformando uma string em int, parse tranforma
    int opcao = int.Parse(opcaoEscolida);

    // uso do if
    /*if (opcao == 1)
    {
        Console.WriteLine("Voce digitou a opção " + opcao);
    }else (opcao == 2){
        Console.WriteLine("Voce digitou a opção " + opcao);
    }*/

    // multiplas if use o switch, tem q ter break em todos
    switch (opcao)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaBanda();
            break;
        case 0:
            Console.WriteLine("\nAté logo :)");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;

    }
}

void RegistrarBanda()
{
    ExibirTituloDaOpcao("Registrar Bandas");
    Console.Write("Digite o nome da banda que desejar registrar: ");
    // ! para nn retornar um valor nulo
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<float>());
    // $ é interporlação de string
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada!!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    /*for(int i = 0; i < listaBandas.Count; ++i)
    {
        Console.WriteLine($"Banda: {listaBandas[i]}");
    }*/

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.Write("\nDigite qualquer tecla para voltar para o meu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int qtLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtLetras, '*');
    Console.Clear();
    Console.WriteLine("\n" + asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    //Digite qual banda deseja avaliar
    //Procuar banda no dicionario, se existir atribuir nota
    //se nn, volta para a pergunta
    ExibirTituloDaOpcao("Avaliar Banda");

    while (true)
    {
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            float nota = float.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Retornar();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
            Retornar();
        }
    }
}

void MediaBanda()
{
    ExibirTituloDaOpcao("Mostrando a Média de uma banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<float> notas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA banda {nomeDaBanda} tem a média de {notas.Average()}");
        Retornar();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Retornar();
    }
}

void Retornar()
{
    Console.WriteLine("\nVocê deseja voltar para o menu principal ? S / N");
    string opcao = Console.ReadLine().ToUpper();
    if (opcao == "S")
    {
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Até logo :) ");
    }

}

ExibirOpcoesDoMenu();