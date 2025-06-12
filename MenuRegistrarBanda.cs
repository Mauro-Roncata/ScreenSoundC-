using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            Console.WriteLine("Registro de bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            String nomeBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeBanda);
            bandasRegistradas.Add(nomeBanda, banda);
            Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
