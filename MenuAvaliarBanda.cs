
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("Avaliar banda");
        Console.Write("Qual banda você deseja avaliar? ");
        string nomeBanda = Console.ReadLine();
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write($"Qual sua nota para a banda {nomeBanda}?");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
            banda.AdicionarNota(new Avaliacao(nota.Nota));
            Console.WriteLine("A nota foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
           
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi encontrada");
        }
    }
}
