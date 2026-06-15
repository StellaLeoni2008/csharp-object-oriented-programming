//Musica.cs (tem que apagar os outros códigos desse arquivo para funcionar)
Musica musica1 = new Musica();
musica1.Nome = "Reflections";
musica1.Artista = "The Neighborhood";
musica1.Duracao = 240;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);


Musica musica2 = new Musica();
musica2.Nome = "Somebody";
musica2.Artista = "Justin Bieber";
musica2.Duracao = 210;
musica2.Disponivel = false;


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();




//Album.cs (tem que apagar os outros códigos desse arquivo para funcionar)
Banda justin = new Banda("Justin Bieber");


Album albumDoJB = new Album("Justice");


Musica musica1 = new Musica(justin, "Peaches")
{
   Duracao = 198,
   Disponivel = true,
};


Musica musica2 = new Musica(justin, "Hold On")
{
   Duracao = 170,
   Disponivel = false,
};


Musica musica3 = new Musica(justin, "Anyone")
{
   Duracao = 190,
   Disponivel = true,
};


albumDoJB.AdicionarMusica(musica1);
albumDoJB.AdicionarMusica(musica2);
albumDoJB.AdicionarMusica(musica3);
justin.AdicionarAlbum(albumDoJB);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
albumDoJB.ExibirMusicasDoAlbum();
justin.ExibirDiscografia();




//Episodio.cs (tem que apagar os outros códigos desse arquivo para funcionar com excessão dos códigos do Podcast)
Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
Console.WriteLine(ep1.DescricaoResumida);
Episodio ep2 = new(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
Console.WriteLine(ep1.DescricaoResumida);



//Podcast.cs (tem que apagar os outros códigos desse arquivo para funcionar com excessão dos códigos do Episodio)
Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
