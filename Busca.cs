using System.Linq;
namespace Lista01;

abstract class Busca{
    public static List<Album> GetArtistAlbums(List<Artista> artistas, string nomeArtista){
        IQueryable<Album> albumsArtista = Artista a in artistas
            where a.Nome == nomeArtista
            select a.Albuns;
        return albumsArtista.ToList();
    }
    public static List<Album> GetAlbumsReleasedInSpecificYear(List<Artista> artistas, int ano){
        IQueryable<Album> albunsInSpecificYear = from artista in artistas
                                                 from album in artistas.Albuns
                                                 where album.DataLancamento.Year == ano; 
                                                 select album;
        return albunsInSpecificYear.ToList();
    }
    public static List<Musica> GetArtistMusics(Artista artista){ 
        List<Album> albuns = artista.Albuns;
        IQueryable<Musica> artistMusicList = from album in artista.Albuns
                                             from musica in album
                                             select musica;
        return artistMusics.ToList();
    }
    public static List<Album> GetArtistAlbumsReleasedInSpecificYear(Artista artista, int ano){
        IQueryable<Album> albunsInSpecificYear = from album in artista.Albuns
                                                 where album.DataLancamento.Year == ano
                                                 select album;
        return albunsInSpecificYear.ToList();
    }
    public static List<Album> GetProdutorAlbunsWithSpecificGender(Produtor produtor, string genero){
        IQueryable<Album> albunsWithSpecificGender = from album in produtor.Albuns
                                                     where album.Genero == genero
                                                     select album;
        return albunsWithSpecificGender.ToList();
    }
    public static IQueryable<Album> GetProdutorAlbumsReleasedInSpecificYear(Produtor produtor, int ano){
        IQueryable<Album> albunsInSpecificYear = from album in produtor.Albuns
                                                 where album.DataLancamento.Year == ano
                                                 select album;
        return albunsInSpecificYear.ToList();
    }
    public static List<Album> OrderAlbumByReleaseDate(List<Album> albums){
        IQueryable<Album> AlbunsOrderedByRelease = albuns.OrderBy(album => album.DataLancamento);
        return AlbunsOrderedByRelease.ToList();
    }
    
}