namespace Lista01;

class Album{
    public string Nome {get; private set;}
    public string Genero {get; private set;}
    public DateTime DataLancamento{get; private set;}
    // Definir o tipo de capa, pode ser string com url pra imagem?
    public string Capa {get; private set;}
    public List<Musica> Musicas {get; private set;}
    public Album(string Nome, string Genero, DateTime DataLancamento, string Capa, List<Musica> Musicas){
        this.Nome = Nome;
        this.Genero = Genero;
        this.DataLancamento = DataLancamento;
        this.Capa = Capa;
        this.Musicas = Musicas;
    }
}