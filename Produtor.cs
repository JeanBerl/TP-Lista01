
public class Produtor : Pessoa{
    public string Produtora {get; private set;}
    public string[] Generos {get; private set;}
    public List<Album> Albuns {get; private set;}
    public Produtor(string Nome, string CPF, DateTime DataNascimento, DateTime DataFalecimento, string Produtora, string[] Generos, List<Album> Albuns) : base(Nome, CPF, DataNascimento, DataFalecimento){
        this.Produtora = Produtora;
        this.Generos = Generos;
        this.Albuns = Albuns;
    }
}