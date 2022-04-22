namespace Lista01;

class Produtor : Pessoa{
    public string Produtora {get; private set;}
    public string[] Generos {get; private set;}
    public List<Album> Albuns {get; private set;}
    public Produtor(string Produtora, string[] Generos, List<Album> Albuns){
        this.Produtora = Produtora;
        this.Generos = Generos;
        this.Albuns = Albuns;
    }
}