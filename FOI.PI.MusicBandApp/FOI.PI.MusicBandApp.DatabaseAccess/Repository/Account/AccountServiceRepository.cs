using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Contracts.Validation;
using System.Linq;
using System;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.DatabaseAccess.Repository.Account
{
    public class AccountServiceRepository : IAccountServiceRepository
    {
        public ErrorDto CreateReservation(ReservationDto reservation)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Rezervacija.Add(new Rezervacija()
                {
                    status_rezervacije = 1,
                    id_osoba = reservation.UserId,
                    id_bend = reservation.BandId,
                    napomena = reservation.Note,
                    datum_od = reservation.DateFrom,
                    datum_do = reservation.DateTo
                });
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public List<ReservationDto> GetAllReservations(int personId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var response = new List<ReservationDto>();
                var reservations = db.Rezervacija.Where(x => x.id_osoba == personId);

                foreach (var reservation in reservations)
                {
                    response.Add(new ReservationDto()
                    {
                        Id = reservation.id_rezervacija,
                        BandId = reservation.id_bend,
                        BandName = reservation.Bend.naziv,
                        DateFrom = reservation.datum_od,
                        DateTo = reservation.datum_do,
                        Note = reservation.napomena,
                        Status = reservation.StatusRezervacije.opis,
                        Charge = reservation.cijena
                    });
                }

                return response;
            }
        }

        public AccountDto Login(string mail, string password)
        {
            using (var db = new MusicBandAppEntities())
            {
                var user = db.Osoba.Where(x => x.mail == mail && x.lozinka == password && x.tip_korisnika != 3);
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
                    responseDto.AccountFounded = true;
                    responseDto.Id = loggedUser.id_osoba;
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
                if (db.Bend.Where(x => x.e_mail == account.Mail).Any())
                {
                    return new ErrorDto()
                    {
                        ErrorCode = (int)ValidationStatusCode.MailAlreadyTaken
                    };
                }

                db.Osoba.Add(new Osoba()
                {
                    adresa = account.Address,
                    ime = account.Name,
                    lozinka = account.Password,
                    mail = account.Mail,
                    mjesto = account.City,
                    prezime = account.Surname,
                    spol = account.Gender,
                    tip_korisnika = 2
                });
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public ErrorDto CancelReservation(int reservationId)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Rezervacija.Where(x => x.id_rezervacija == reservationId).FirstOrDefault().status_rezervacije = 4;
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public ErrorDto SubmitReservaton(int reservationId)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Rezervacija.Where(x => x.id_rezervacija == reservationId).FirstOrDefault().status_rezervacije = 2;
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public List<AccountDto> GetAccountsWithoutBand()
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<AccountDto>();
                foreach (var account in db.Osoba.Where(x => x.id_bend == null))
                {
                    responseDto.Add(new AccountDto()
                    {
                        Id = account.id_osoba,
                        Name = account.ime,
                        Surname = account.prezime,
                        Gender = account.spol,
                        Mail = account.mail
                    });
                }
                return responseDto;
            }
        }

        public List<AccountDto> GetBandMembers(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<AccountDto>();
                foreach (var account in db.Osoba.Where(x => x.id_bend == bandId))
                {
                    responseDto.Add(new AccountDto()
                    {
                        Id = account.id_osoba,
                        Name = account.ime,
                        Surname = account.prezime,
                        Gender = account.spol,
                        Mail = account.mail
                    });
                }
                return responseDto;
            }
        }
    }
}
