using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band;
using FOI.PI.MusicBandApp.Contracts.Validation;
using System.Linq;
using System.Collections.Generic;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Common.Security;

namespace FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band
{
    public class BandServiceRepository : IBandServiceRepository
    {
        public BandDto GetBandDetails(int id)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new BandDto();
                var band = db.Bend.Where(x => x.id_bend == id);
                if (band.Count() > 1)
                {
                    responseDto.Errors.Add(new ErrorDto()
                    {
                        ErrorCode = (int)ValidationStatusCode.ResultsetHasMoreItems
                    });
                }
                else if (band.Any())
                {
                    responseDto = MapBand(band.First());
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

        public ErrorDto Register(BandDto band)
        {
            using (var db = new MusicBandAppEntities())
            {
                if (db.Osoba.Where(x => x.mail == band.Mail).Any())
                {
                    return new ErrorDto()
                    {
                        ErrorCode = (int)ValidationStatusCode.MailAlreadyTaken
                    };
                }
                db.Bend.Add(new Bend()
                {
                    broj_clanova = band.MemberCount,
                    datum_osnivanja = band.Founded,
                    e_mail = band.Mail,
                    facebook = band.FacebookPage,
                    instagram = band.InstagramPage,
                    kontakt = band.Contact,
                    mjesto = band.City,
                    naziv = band.Name,
                    slika = band.Image,
                    lozinka = band.Password,
                    web_stranica = band.WebPage
                });
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public BandDto GetBand(string mail, string password)
        {
            using (var db = new MusicBandAppEntities())
            {
                var account = db.Bend.Where(x => x.e_mail == mail && x.tip_korisnika != 3);
                var responseDto = new BandDto();
                if (account.Count() > 1)
                {
                    responseDto.Errors.Add(new ErrorDto()
                    {
                        ErrorCode = (int)ValidationStatusCode.ResultsetHasMoreItems
                    });
                }
                else if (account.Any())
                {
                    var str = account.First().lozinka.Decrypt();
                    if (string.Compare(str, password) != 0)
                        responseDto.Errors.Add(new ErrorDto()
                        {
                            ErrorCode = (int)ValidationStatusCode.UserDoesNotExists
                        });

                    else
                        responseDto = MapBand(account.First());
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

        public List<BandDto> GetAllBands()
        {
            using (var db = new MusicBandAppEntities())
            {
                var response = new List<BandDto>();
                foreach (var band in db.Bend)
                {
                    response.Add(MapBand(band));
                }
                return response;
            }
        }

        public List<RepertoireDto> GetBandRepertoire(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var response = new List<RepertoireDto>();
                var band = db.Bend.Where(x => x.id_bend == bandId).FirstOrDefault();
                var songs = band.Pjesma1;
                foreach (var song in songs)
                {
                    response.Add(new RepertoireDto()
                    {
                        Duration = song.trajanje.ToString(),
                        Gender = song.Zanr.naziv,
                        Name = song.naziv,
                        Performer = song.izvodac,
                        Year = song.godina_izdanja
                    });
                }

                return response;
            }
        }

        public ErrorDto DeleteBand(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new ErrorDto();
                var band = db.Bend.Where(x => x.id_bend == bandId);

                if (band.Count() > 1)
                {
                    responseDto.ErrorCode = (int)ValidationStatusCode.ResultsetHasMoreItems;
                }
                else
                {
                    band.FirstOrDefault().tip_korisnika = 3;
                    db.SaveChanges();
                }
                return responseDto;
            }
        }

        public ErrorDto UpdateBand(BandDto band)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new ErrorDto();
                var resultSet = db.Bend.Where(x => x.id_bend == band.Id);

                if (resultSet.Count() > 1)
                {
                    responseDto.ErrorCode = (int)ValidationStatusCode.ResultsetHasMoreItems;
                }
                else if (resultSet.Any())
                {
                    var foundedBand = resultSet.FirstOrDefault();
                    foundedBand.broj_clanova = band.MemberCount;
                    foundedBand.datum_osnivanja = band.Founded;
                    foundedBand.e_mail = band.Mail;
                    foundedBand.facebook = band.FacebookPage;
                    foundedBand.instagram = band.InstagramPage;
                    foundedBand.kontakt = band.Contact;
                    foundedBand.lozinka = band.Password;
                    foundedBand.mjesto = band.City;
                    foundedBand.naziv = band.Name;
                    foundedBand.slika = band.Image;
                    db.SaveChanges();
                }
                else
                {
                    responseDto.ErrorCode = (int)ValidationStatusCode.UserDoesNotExists;
                }

                return responseDto;
            }
        }

        public List<ReservationDto> GetReservations(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<ReservationDto>();

                var reservations = db.Rezervacija.Where(x => x.id_bend == bandId && x.status_rezervacije == 1);
                foreach (var reservation in reservations)
                {
                    responseDto.Add(new ReservationDto()
                    {
                        BandName = reservation.Bend.naziv,
                        Charge = reservation.cijena,
                        DateFrom = reservation.datum_od,
                        DateTo = reservation.datum_do,
                        Id = reservation.id_rezervacija,
                        Note = reservation.napomena,
                        Status = reservation.StatusRezervacije.opis
                    });
                }

                return responseDto;
            }
        }

        public List<ReservationDto> GetReservatedDates(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<ReservationDto>();

                var reservations = db.Rezervacija.Where(x => x.id_bend == bandId && x.status_rezervacije == 2);
                foreach (var reservation in reservations)
                {
                    responseDto.Add(new ReservationDto()
                    {
                        DateFrom = reservation.datum_od,
                        DateTo = reservation.datum_do,
                        Status = reservation.StatusRezervacije.opis,
                        Charge = reservation.cijena
                    });
                }

                return responseDto;
            }
        }

        public ErrorDto CancelReservation(int reservationId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new ErrorDto();
                var resultSet = db.Rezervacija.Where(x => x.id_rezervacija == reservationId);

                if (resultSet.Count() > 1)
                {
                    responseDto.ErrorCode = (int)ValidationStatusCode.ResultsetHasMoreItems;
                }
                else if (resultSet.Any())
                {
                    resultSet.FirstOrDefault().status_rezervacije = 4;
                    db.SaveChanges();
                }
                else
                {
                    responseDto.ErrorCode = (int)ValidationStatusCode.UserDoesNotExists;
                }

                return responseDto;
            }
        }

        public ErrorDto SetReservationPrice(int reservationId, double price)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new ErrorDto();
                var resultSet = db.Rezervacija.Where(x => x.id_rezervacija == reservationId);

                if (resultSet.Count() > 1)
                {
                    responseDto.ErrorCode = (int)ValidationStatusCode.ResultsetHasMoreItems;
                }
                else if (resultSet.Any())
                {
                    if (resultSet.FirstOrDefault().status_rezervacije == 1)
                    {
                        resultSet.FirstOrDefault().cijena = price;
                        db.SaveChanges();
                    }
                    else
                    {
                        responseDto.ErrorCode = (int)ValidationStatusCode.InvalidReservationStatus;
                    }
                }
                else
                {
                    responseDto.ErrorCode = (int)ValidationStatusCode.UserDoesNotExists;
                }

                return responseDto;
            }
        }

        #region Helper
        private BandDto MapBand(Bend foundedBand)
        {
            var responseDto = new BandDto();

            responseDto.City = foundedBand.mjesto;
            responseDto.Contact = foundedBand.kontakt;
            responseDto.FacebookPage = foundedBand.facebook;
            responseDto.Founded = foundedBand.datum_osnivanja;
            responseDto.Id = foundedBand.id_bend;
            responseDto.Image = foundedBand.slika;
            responseDto.InstagramPage = foundedBand.instagram;
            responseDto.Mail = foundedBand.e_mail;
            responseDto.MemberCount = foundedBand.broj_clanova;
            responseDto.Name = foundedBand.naziv;
            responseDto.WebPage = foundedBand.web_stranica;
            responseDto.AccountType = foundedBand.tip_korisnika;
            responseDto.BandFounded = true;

            return responseDto;
        }
        #endregion
    }
}
