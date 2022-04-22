namespace Lista01;

abstract class Busca{
    public static GetArtistAlbums(List<Artista> artistas, string nomeArtista){
        IQueryable<Album> albumsArtista = Artista a in artistas
            where a.Nome == nomeArtista
            select a.Albuns;
    }
    public static GetAlbumsReleasedInSpecificYear(List<Artista> artistas, int ano){

    }
    public static List<Musica> GetArtistMusics(Artista artista){ 
        IQueryable<Musica> musicas = Album a in artista.Albuns
            select a.Albuns;
        foreach(Musica in musicas){

        }
    }
}