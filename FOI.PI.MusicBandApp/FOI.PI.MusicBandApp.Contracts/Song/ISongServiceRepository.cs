using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Song
{
    public interface ISongServiceRepository
    {
        ErrorDto AddSong(SongDto song);
        ErrorDto AddBandSong(int bandId, int songId);
        ErrorDto DeleteSong(int bandId, int songId);
        List<SongDto> GetBandSongs(int bandId);
        List<SongDto> GetAvailableSongs(int bandId);
        List<GenreDto> GetGenres();
    }
}
