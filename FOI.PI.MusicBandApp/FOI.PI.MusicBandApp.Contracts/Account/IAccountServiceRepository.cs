using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Account
{
    public interface IAccountServiceRepository
    {
        AccountDto Login(string mail, string password);
        ErrorDto Register(AccountDto account);
        List<ReservationDto> GetAllReservations(int personId);
        ErrorDto CreateReservation(ReservationDto reservation);
        ErrorDto CancelReservation(int reservationId);
        ErrorDto SubmitReservaton(int reservationId);
        List<AccountDto> GetAccountsWithoutBand();
        List<AccountDto> GetBandMembers(int bandId);
    }
}
