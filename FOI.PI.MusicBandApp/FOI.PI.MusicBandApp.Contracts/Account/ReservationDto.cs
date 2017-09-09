using System;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Account
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int UserId { get; set; }
        public int BandId { get; set; }
        public string BandName { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public double? Charge { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public ReservationDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
