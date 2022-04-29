using System;

class Artista : Pessoa{
    public DateTime DataDoContrato {get; private set;}
    public string Genero {get; private set;}
    public List<Album> Albuns {get; private set;}
    public Artista(DateTime DataDoContrato, string Genero, List<Album> Albuns){
        this.DataDoContrato = DataDoContrato;
        this.Genero = Genero;
        this.Albuns = Albuns;
    }
}