using FOI.PI.MusicBandApp.Contracts.Account;

namespace FOI.PI.MusicBandApp.Business.Account
{
    public interface IAccountManagementService
    {
        AccountDto Login(string mail, string password);
    }
}
