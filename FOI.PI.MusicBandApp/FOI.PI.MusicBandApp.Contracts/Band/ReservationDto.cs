using System;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Band
{
    public class ReservationDto
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int UserId { get; set; }
        public int BandId { get; set; }
        public string Note { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public ReservationDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
