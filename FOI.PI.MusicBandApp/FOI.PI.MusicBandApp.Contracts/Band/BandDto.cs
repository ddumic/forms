using System;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Band
{
    public class BandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? MemberCount { get; set; }
        public int AccountType { get; set; }
        public string City { get; set; }
        public DateTime? Founded { get; set; }
        public string WebPage { get; set; }
        public string FacebookPage { get; set; }
        public string InstagramPage { get; set; }
        public string Contact { get; set; }
        public string Mail { get; set; }
        public bool BandFounded { get; set; }
        public byte[] Image { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public BandDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
