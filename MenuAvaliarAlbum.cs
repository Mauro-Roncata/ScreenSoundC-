
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum
{

    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("Avaliar album");
        Console.Write("Qual banda você deseja avaliar? ");
        string nomeBanda = Console.ReadLine();
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {

            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write("Qual álbum você deseja avaliar? ");
            string nomeAlbum = Console.ReadLine();

            if (banda.Albuns.Any(a => a.Nome.Equals(nomeAlbum)))

            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(nomeAlbum));
                Console.Write($"Qual sua nota para o álbum {nomeAlbum} da banda {nomeBanda}? ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
                album.AdicionarNota(nota);
                Console.WriteLine("A nota foi registrada com sucesso!");
            }

            else
            {
                Console.WriteLine($"O álbum {nomeAlbum} não foi encontrado na banda {nomeBanda}");
            }


            }
            else
            {
                Console.WriteLine($"A banda {nomeBanda} não foi encontrada");
            }
        }
    }

