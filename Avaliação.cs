﻿namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0) { nota = 0; }
        if (nota >= 10) {nota = 10; }   
        Nota = Nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(Console.ReadLine()!);
        return new Avaliacao (nota);
    }
}
