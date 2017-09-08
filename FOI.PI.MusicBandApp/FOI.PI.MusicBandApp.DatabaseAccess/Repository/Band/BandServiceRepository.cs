using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band;
using FOI.PI.MusicBandApp.Contracts.Validation;
using System.Linq;

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
