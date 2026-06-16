using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;

using System.Text.Json;
using System.Text.Json.Serialization;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson")
        
        // var musicasPreferidasDaStella = new MusicasPreferidas("Stella");
        // musicasPreferidasDaStella.AdicionarMusicasPreferidas(musicas[1966]);
        // musicasPreferidasDaStella.AdicionarMusicasPreferidas(musicas[1856]);
        // musicasPreferidasDaStella.AdicionarMusicasPreferidas(musicas[1538]);
        // musicasPreferidasDaStella.AdicionarMusicasPreferidas(musicas[1623]);
        // musicasPreferidasDaStella.AdicionarMusicasPreferidas(musicas[1279]);

        // musicasPreferidasDaStella.ExibirMusicasPreferidas();

        // musicasPreferidasDaStella.GerarArquivoJSON();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}



