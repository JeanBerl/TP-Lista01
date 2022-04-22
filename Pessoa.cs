using System.DateTime

namespace Lista01;

class Pessoa{
    public string Nome {get;}
    public string CPF {public get; private set;}
    public DateTime DataNascimento {public get; private set;}
    public DateTime DataFalecimento {public get; private set;}
}