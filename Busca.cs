namespace Lista01;
using System.Linq;
abstract class Busca{
    public static GetArtistAlbums(List<Artista> artistas, string nomeArtista){
        IQueryable<Album> albumsArtista = Artista a in artistas
            where a.Nome == nomeArtista
            select a.Albuns;
    }
    public static IQueryable<Album> GetAlbumsReleasedInSpecificYear(List<Artista> artistas, int ano){
        IQueryable<Album> albunsInSpecificYear = from artista in artistas
                                                 from album in artistas.Albuns
                                                 where album.DataLancamento.Year == ano; 
                                                 select album;
        return albunsInSpecificYear;
    }
    public static IQueryable<Musica> GetArtistMusics(Artista artista){ 
        List<Album> albuns = artista.Albuns;
        IQueryable<Musica> artistMusicList = from album in artista.Albuns
                                             from musica in album
                                             select musica;
        return artistMusics;
    }
    public static IQueryable<Album> GetArtistAlbumsReleasedInSpecificYear(Artista artista, int ano){
        IQueryable<Album> albunsInSpecificYear = from album in artista.Albuns
                                                 where album.DataLancamento.Year == ano
                                                 select album;
        return albunsInSpecificYear;
    }
    public static IQueryable<Album> GetProdutorAlbunsWithSpecificGender(Produtor produtor, string genero){
        IQueryable<Album> albunsWithSpecificGender = from album in produtor.Albuns
                                                     where album.Genero == genero
                                                     select album;
        return albunsWithSpecificGender;
    }
    public static IQueryable<Album> GetProdutorAlbumsReleasedInSpecificYear(Produtor produtor, int ano){
        IQueryable<Album> albunsInSpecificYear = from album in produtor.Albuns
                                                 where album.DataLancamento.Year == ano
                                                 select album;
        return albunsInSpecificYear;
    }
    
}