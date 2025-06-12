using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuExibirBandasRegistradas
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            Console.WriteLine("Exibindo Bandas Regitradas\n");

            foreach (String banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
         
        }
    }
}
