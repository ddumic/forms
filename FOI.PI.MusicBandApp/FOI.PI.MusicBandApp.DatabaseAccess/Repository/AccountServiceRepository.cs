using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Contracts.Validation;
using System.Linq;

namespace FOI.PI.MusicBandApp.DatabaseAccess.Repository
{
    public class AccountServiceRepository : IAccountServiceRepository
    {
        public AccountDto Login(string mail, string password)
        {
            using (var db = new MusicBandAppEntities())
            {
                var user = db.Osoba.Where(x => x.mail == mail && x.lozinka == password);
                var responseDto = new AccountDto();
                if (user.Count() > 1)
                {
                    responseDto.Errors.Add(new ErrorDto()
                    {
                        ErrorCode = (int)ValidationStatusCode.ResultsetHasMoreItems
                    });
                }
                else if (user.Any())
                {
                    var loggedUser = user.First();
                    responseDto.Address = loggedUser.adresa;
                }
                else
                {
                    responseDto.Errors.Add(new ErrorDto()
                    {
                        ErrorCode = (int)ValidationStatusCode.UserDoesNotExists
                    });
                }
                return responseDto;
            }
        }
    }
}
