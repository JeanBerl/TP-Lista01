using System;

public class Artista : Pessoa{
    public DateTime DataDoContrato {get; private set;}
    public string Genero {get; private set;}
    public List<Album> Albuns {get; private set;}
    public Artista(string Nome, string CPF, DateTime DataNascimento, DateTime DataFalecimento, DateTime DataDoContrato, string Genero, List<Album> Albuns) : base(Nome, CPF, DataNascimento, DataFalecimento)
    {
        this.DataDoContrato = DataDoContrato;
        this.Genero = Genero;
        this.Albuns = Albuns;
    }
}