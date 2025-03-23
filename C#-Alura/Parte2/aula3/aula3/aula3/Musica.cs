namespace aula3;

public class Musica
{
    // Quando adiciona um get e set o csharp muda a maneira de nomear começando com Maiuscula
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida
    {
        get
        {
            return $"A Musica {Nome} pertence a banda {Artista}";
        }
    }
    
    // Outra Forma, chamada Lambada
    // public string DescricaoResumida => return $"A Musica {Nome} pertence a banda {Artista}";
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}