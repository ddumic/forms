using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;

namespace FOI.PI.MusicBandApp.Business.Account
{
    public interface IAccountManagementService
    {
        LoginDto Login(string mail, string password);
        ErrorDto Register(AccountDto account);
    }
}
