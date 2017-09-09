using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Song;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Business.Song
{
    public interface ISongManagementService
    {
        ErrorDto AddSong(SongDto song);
        ErrorDto DeleteSong(int bandId, int songId);
        List<SongDto> GetSongs(int bandId);
        List<GenreDto> GetGenres();
    }
}
