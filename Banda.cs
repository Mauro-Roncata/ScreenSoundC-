
namespace ScreenSound.Modelos;
internal class Banda : IAvaliavel
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    public List<Album> Albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public string Nome { get; }
    public double mediaNotas
    {
        get 
        { 
        if (notas.Count == 0) return 0;
        else return notas.Average(a => a.Nota);
        }
    }

   // public bool Albuns { get; internal set; }

    public void AdicionarAlbum(Album album)
    {
        Albuns.Add(album);
    }

    public void AdicionarNota (Avaliacao nota)
    {
        notas.Add(nota); 
    } 

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in Albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }

    public static implicit operator List<object>(Banda v)
    {
        throw new NotImplementedException();
    }
}