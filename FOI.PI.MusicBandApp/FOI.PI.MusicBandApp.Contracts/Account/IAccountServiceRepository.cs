namespace FOI.PI.MusicBandApp.Contracts.Account
{
    public interface IAccountServiceRepository
    {
        AccountDto Login(string mail, string password);
    }
}
