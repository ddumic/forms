using System.Collections.Generic;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Song;

namespace FOI.PI.MusicBandApp.Business.Song
{
    public class SongManagementService : ISongManagementService
    {
        private readonly ISongServiceRepository _songServiceRepository;

        public SongManagementService(ISongServiceRepository songServiceRepository)
        {
            _songServiceRepository = songServiceRepository;
        }

        public ErrorDto AddSong(SongDto song)
        {
            return _songServiceRepository.AddSong(song);
        }

        public ErrorDto DeleteSong(int bandId, int songId)
        {
            return _songServiceRepository.DeleteSong(bandId, songId);
        }

        public List<GenreDto> GetGenres()
        {
            return _songServiceRepository.GetGenres();
        }

        public List<SongDto> GetSongs(int bandId)
        {
            return _songServiceRepository.GetSongs(bandId);
        }
    }
}
