// Screen Sound
string mensagemDeBoasVindas = "Boas vindas GuruGuru";

//Lista <tipo> nomeDaLista
List<string> listaBandas = new List<string>();

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
            Console.WriteLine("Voce digitou a opção " + opcao);
            break;
        case 3:
            Console.WriteLine("Voce digitou a opção " + opcao);
            break;
        case 4:
            Console.WriteLine("Voce digitou a opção " + opcao);
            break;
        case 0:
            Console.WriteLine("Até logo :)");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;

    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda que desejar registrar: ");
    // ! para nn retornar um valor nulo
    string nomeDaBanda = Console.ReadLine()!;
    listaBandas.Add(nomeDaBanda);
    // $ é interporlação de string
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada!!");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();