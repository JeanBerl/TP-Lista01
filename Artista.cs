using System.DateTime
namespace Lista01;

class Artista : Pessoa{
    public DateTime DataDoContrato {get; private set;}
    public string Genero {get; private set;}
    public Album[] Albuns {get; private set;}
}