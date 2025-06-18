class Album
{
    private List<Musica> musicaList = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicaList.Add(musica);
    }
}