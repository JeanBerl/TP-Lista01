// See https://aka.ms/new-console-template for more information
List<Album> albums = new List<Album>(); 
List<Musica> musicasContraband = new List<Musica>();
Musica musica1 = new Musica("Sucker Train Blues", new TimeSpan(0, 4, 27), "Hard rock", new DateTime(2004, 06, 08, 5, 0, 0));
Musica musica2 = new Musica("Do It for the Kids", new TimeSpan(0, 3, 55), "Hard rock", new DateTime(2004, 06, 08, 5, 0, 0));
musicasContraband.Add(musica1);
musicasContraband.Add(musica2);
Album contraband = new Album("Contraband", "Hard rock", new DateTime(2004, 06, 08, 5, 0, 0), "Mulher com Revólver", musicasContraband);
var a = new Artista("Slash", "12672778663", new DateTime(1965, 07, 23, 7, 0, 0), new DateTime(2022, 3, 1, 7, 0, 0), new DateTime(2008, 3, 1, 7, 0, 0), "Rock", albums);
foreach(Musica musica in musicasContraband){
    Console.WriteLine(musica.Nome);
}
Console.WriteLine(a.Genero);