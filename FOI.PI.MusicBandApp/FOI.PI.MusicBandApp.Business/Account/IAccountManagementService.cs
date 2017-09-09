using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Business.Account
{
    public interface IAccountManagementService
    {
        LoginDto Login(string mail, string password);
        ErrorDto Register(AccountDto account);
        List<ReservationDto> GetAllReservations(int personId);
        ErrorDto CreateReservation(ReservationDto reservation);
        ErrorDto CancelReservation(int reservationId);
    }
}
