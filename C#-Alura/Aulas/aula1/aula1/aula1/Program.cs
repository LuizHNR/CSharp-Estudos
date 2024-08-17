// Screen Sound
string mensagemDeBoasVindas = "Boas vindas GuruGuru";

//void é uma função q não devolve nada, sem return
void ExibirMensagemDeBoasVindas()
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

ExibirMensagemDeBoasVindas();