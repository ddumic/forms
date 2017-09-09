using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Song
{
    public interface ISongServiceRepository
    {
        ErrorDto AddSong(SongDto song);
        ErrorDto DeleteSong(int bandId, int songId);
        List<SongDto> GetSongs(int bandId);
        List<GenreDto> GetGenres();
    }
}
