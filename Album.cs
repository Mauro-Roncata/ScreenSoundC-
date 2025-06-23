namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicaList = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public string Nome { get; }

    public Album(string nome)
    {
        Nome = nome;
    }

    public int DuracaoTotal => musicaList.Sum(m => m.Duracao);

    public double mediaNotas
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicaList.Add(musica);
    }

    public void ExibirMusicaAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicaList)
        {
        Console.WriteLine($"Múscia: {musica.Nome}");
        }
        int minutosTotal = DuracaoTotal / 60;
        int segundosTotal = DuracaoTotal % 60;
        Console.WriteLine($"\nDuração total do album: {minutosTotal} minutos e {segundosTotal} segundos");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}