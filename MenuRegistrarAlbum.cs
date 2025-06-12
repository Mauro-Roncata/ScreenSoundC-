using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarAlbum
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            Console.WriteLine("Registro de álbuns");
            Console.Write("Digite a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarAlbum(new Album(nomeDaBanda));
                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
                
            }
            else
            {
                Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
              
            }

        }
    }
}
