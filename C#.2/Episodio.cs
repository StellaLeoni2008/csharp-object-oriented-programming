class Episodio
{
    private List<string> convidados = new();
    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        EpisodiosOrdenados = ordem;
    }

    public string Titulo {get; }
    public int Duracao {get; }
    public List<double> EpisodiosOrdenados {get; set; } = new List<double>();
    public string DescricaoResumida => 
        $"O título do episódio é {Titulo} com {EpisodiosOrdenados} ({Duracao} min) - {string.Join(", ", convidados)}";
    

    public void AdicionarConvidados(string convidado)
    {
       convidados.Add(convidado)
    }
}