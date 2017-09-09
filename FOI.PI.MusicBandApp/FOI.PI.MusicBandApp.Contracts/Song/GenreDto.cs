using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Song
{
    public class GenreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public GenreDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
