using System;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Song
{
    public class SongDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Performer { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Year { get; set; }
        public GenreDto Genre { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public SongDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
