Episodio ep1 = new Episodio(1, "Introdução ao C#", 30);
ep1.AddConvidado("Alice");

Episodio ep2 = new Episodio(2, "Avançado em C#", 45);
ep2.AddConvidado("Bob");
ep2.AddConvidado("Charlie");

Podcast podcast = new Podcast("Aprendendo C#", "Leonardo");
podcast.AddEpisodio(ep1);
podcast.AddEpisodio(ep2);
podcast.ListarEpisodios();
