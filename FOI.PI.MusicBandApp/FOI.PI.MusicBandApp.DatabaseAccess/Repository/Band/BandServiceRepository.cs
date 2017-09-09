using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band;
using FOI.PI.MusicBandApp.Contracts.Validation;
using System.Linq;
using System.Collections.Generic;

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
                var account = db.Bend.Where(x => x.e_mail == mail && x.lozinka == password && x.tip_korisnika != 3);
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
