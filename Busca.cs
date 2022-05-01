using System.Linq;

public abstract class Busca{
    public static List<Album>? GetSpecificArtistAlbums(List<Artista> artistas, string nomeArtista){
        // var albumsArtista = (from artista in artistas
        //                     where ((artista.Nome) == nomeArtista)
        //                     select artista.Albuns);
        var albumsArtista = artistas.FirstOrDefault(a => a.Nome == nomeArtista);
        return albumsArtista.Albuns;
    }
    public static List<Album> GetAlbumsReleasedInSpecificYear(List<Artista> artistas, int ano){
        var albunsInSpecificYear = from artista in artistas
                                   from album in artista.Albuns
                                   where (album.DataLancamento.Year == ano)
                                   select album;
        return albunsInSpecificYear.ToList();
    }
    public static List<Musica> GetArtistMusics(Artista artista){ 
        List<Album> albuns = artista.Albuns;
        var artistMusics = albuns.SelectMany(album => album.Musicas);
        return artistMusics.ToList();
    }
    public static List<Album> GetArtistAlbumsReleasedInSpecificYear(Artista artista, int ano){
        var albunsInSpecificYear = from album in artista.Albuns
                                   where album.DataLancamento.Year == ano
                                   select album;
        return albunsInSpecificYear.ToList();
    }
    public static List<Album> GetProdutorAlbunsWithSpecificGender(Produtor produtor, string genero){
        var albunsWithSpecificGender = from album in produtor.Albuns
                                    where album.Genero == genero
                                    select album;
        return albunsWithSpecificGender.ToList();
    }
    public static IEnumerable<Album> GetProdutorAlbumsReleasedInSpecificYear(Produtor produtor, int ano){
        var albunsInSpecificYear = from album in produtor.Albuns
                                where album.DataLancamento.Year == ano
                                select album;
        return albunsInSpecificYear.ToList();
    }
    public static List<Album> OrderAlbumByReleaseDate(List<Album> albuns){
        var AlbunsOrderedByRelease = albuns.OrderBy(album => album.DataLancamento);
        return AlbunsOrderedByRelease.ToList();
    }
    
}