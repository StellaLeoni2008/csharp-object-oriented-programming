namespace ScreenSound_04.Modelos;

using System.Text.Json;
using System.Text.Json.Serialization;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; }

    public MusicasPreferidas(string nome) {
        Nome = nome;
        ListaDeMusicasPreferidas = new List<Musica>();
    }

    public void AdicionarMusicasPreferidas(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicasPreferidas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJSON()
    {
        string json = JsonSerializer.Serialize( new 
        {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas
        });
        string nomeDoArquivo = $"musicas-preferidas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo JSON foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
