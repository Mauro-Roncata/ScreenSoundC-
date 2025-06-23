//ScreenSound

using System.ComponentModel;
using System.ComponentModel.Design;
using ScreenSound.Menus;
using ScreenSound.Modelos;


//Criando logo e mesagem de boas vindas
string msgBoasVindas = "Boas vindas ao Screen Sound";

void ExibirLogo()
{
    Console.WriteLine(msgBoasVindas);
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝");
}

//Criando lista vazia para armazenar bandas registradas
//List<String> bandasRegistradas = new List<String>{"The Beatles", "U2", "Iron Maiden" };

Banda ira = new("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles); ;

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para registrar um álbum");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");

    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
 

   switch (opcaoEscolhidaNum)
    {
        case 1:
            MenuRegistrarBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            VoltarMenu();
            ExibirOpcoesMenu();
            break; 

        case 2: MenuExibirBandasRegistradas menu2 = new();
            menu2.Executar(bandasRegistradas);
            VoltarMenu();
            ExibirOpcoesMenu();
            break;

        case 3: MenuAvaliarBanda menu3 = new();
                menu3.Executar(bandasRegistradas);
            Console.Clear();
            VoltarMenu();
            ExibirOpcoesMenu();
            break;

        case 4:
            MenuRegistrarAlbum menu4 = new();
            menu4.Executar(bandasRegistradas);
            VoltarMenu();
            ExibirOpcoesMenu();
            break;

            case 5:
            MenuAvaliarAlbum menu5 = new();
            menu5.Executar(bandasRegistradas);
            VoltarMenu();
            ExibirOpcoesMenu();
            break;


        case -1: Console.WriteLine("Encerrando programa...");
            break;

        default: Console.WriteLine("Opção inválida.");
            break;
    }
    
    
}

void VoltarMenu ()
{
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesMenu();
}


ExibirLogo();
ExibirOpcoesMenu();