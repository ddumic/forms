using FOI.PI.MusicBandApp.Contracts.Account;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Band
{
    public interface IBandServiceRepository
    {
        BandDto GetBandDetails(int id);
        ErrorDto Register(BandDto band);
        BandDto GetBand(string mail, string password);
        List<BandDto> GetAllBands();
        List<RepertoireDto> GetBandRepertoire(int bandId);
        ErrorDto DeleteBand(int bandId);
        ErrorDto UpdateBand(BandDto band);
        List<ReservationDto> GetReservations(int bandId);
        List<ReservationDto> GetReservatedDates(int bandId);
        ErrorDto CancelReservation(int reservationId);
        ErrorDto SetReservationPrice(int reservationId, double price);
    }
}
