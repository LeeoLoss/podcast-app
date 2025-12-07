class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string titulo, string host)
    {
        Titulo = titulo;
        Host = host;
        Episodios = new List<Episodio>();
    }
    public string Titulo { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;


    public void AddEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }


    public void ListarEpisodios()
    {
        Console.WriteLine($"Podcast: {Titulo} - Host: {Host} - Total de Episódios: {episodios.Count}");
        foreach (var ep in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(ep.Resumo);
        }
    }
}
