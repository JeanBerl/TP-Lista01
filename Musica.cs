
class Musica{
    public string Nome {get; private set;}
    public TimeSpan Duracao {get; private set;}
    public string Genero {get; private set;}
    public DateTime DataLancamento {get; private set;}
    public Musica(string nome, TimeSpan duracao, string genero, DateTime datalancamento){
        this.Nome = nome;
        this.Duracao = duracao;
        this.Genero = genero;
        this.DataLancamento = datalancamento;
    }
}