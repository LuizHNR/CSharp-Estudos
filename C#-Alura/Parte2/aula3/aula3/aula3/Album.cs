namespace aula3;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);  

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica); 
    }

    public void ExibirMusicasdoAlbum()
    {
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musicas do Album {Nome}:");
            Console.WriteLine($"Musicas: {musica.Nome}\n"); 
        }

        Console.WriteLine($"Para ouvir esse album inteiro você precisa de: {DuracaoTotal} segundos");
    }
}