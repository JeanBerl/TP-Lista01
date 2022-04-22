namespace Lista01;

class Album{
    public string Nome {get; private set;}
    public string Genero {get; private set;}
    public DateTime DataLancamento{get; private set;}
    // Definir o tipo de capa, pode ser string com url pra imagem?
    public string capa {get; private set;}
    public Musica[] musicas {get; private set;}
}