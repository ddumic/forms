using System;

namespace FOI.PI.MusicBandApp.Desktop.ViewModel
{
    public class ReservationListItemViewModel
    {
        public int Id { get; set; }
        public string Band { get; set; }
        public string Status { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public double? Charge { get; set; }
        public string Note { get; set; }
    }
}
