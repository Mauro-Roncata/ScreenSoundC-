using ScreenSound.Modelos;

Banda ira = new("Ira");
Banda beatles = new("The Beatles");
Banda queen = new Banda("Queen");

Album albumQueen = new Album("A night at the opera");


Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};



albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumQueen.ExibirMusicaAlbum();
queen.ExibirDiscografia();
