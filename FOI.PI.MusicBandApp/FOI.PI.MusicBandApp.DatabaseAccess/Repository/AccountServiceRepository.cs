using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Contracts.Validation;
using System;
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
                    responseDto.AccountType = loggedUser.tip_korisnika;
                    responseDto.City = loggedUser.mjesto;
                    responseDto.Gender = loggedUser.spol;
                    responseDto.Mail = loggedUser.mail;
                    responseDto.Name = loggedUser.ime;
                    responseDto.Surname = loggedUser.prezime;
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

        public ErrorDto Register(AccountDto account)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Osoba.Add(new Osoba()
                {
                    adresa = account.Address,
                    ime = account.Name,
                    lozinka = account.Password,
                    mail = account.Mail,
                    mjesto = account.City,
                    prezime = account.Surname,
                    spol = account.Gender,
                    tip_korisnika = account.AccountType
                });
                db.SaveChanges();
                return new ErrorDto();
            }
        }
    }
}
