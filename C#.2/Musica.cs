class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {get; }
    public Banda Artista {get; }
    public int Duracao {get; set; }
    public bool Disponivel {get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista} e tem duração de {Duracao} segundos.";
    

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Disponível: {(Disponivel ? "Disponível no plano gratuito\n" : "Adquira o plano premium para ouvir esta música\n")}");
    }
}