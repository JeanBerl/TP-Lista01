
public abstract class Pessoa{
    public string Nome {get; set;}
    public string CPF {get; set;}
    public DateTime DataNascimento {get; set;}
    public DateTime DataFalecimento {get; set;}
    public Pessoa(string Nome, string CPF, DateTime DataNascimento, DateTime DataFalecimento){
        this.Nome = Nome;
        this.CPF = CPF;
        this.DataNascimento = DataNascimento;
        this.DataFalecimento = DataFalecimento;
    }
}