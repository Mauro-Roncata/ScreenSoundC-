
namespace ScreenSound.Modelos
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);

        double mediaNotas { get; }
    }
}
