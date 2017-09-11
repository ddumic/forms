using System.Collections.Generic;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Finance;
using System.Linq;

namespace FOI.PI.MusicBandApp.DatabaseAccess.Repository.Finance
{
    public class FinanceServiceRepository : IFinanceServiceRepository
    {
        public ErrorDto AddCharge(FinanceDto finance)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Financije.Add(new Financije()
                {
                    id_bend = finance.BandId,
                    iznos = finance.Price,
                    naziv = finance.Name,
                    opis = finance.Note
                });
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public List<FinanceDto> GetBandFinanceStatus(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<FinanceDto>();

                foreach (var item in db.Financije.Where(x => x.id_bend == bandId))
                {
                    responseDto.Add(new FinanceDto()
                    {
                        BandId = item.id_bend,
                        Id = item.id_trosak,
                        Name = item.naziv,
                        Note = item.opis,
                        Price = item.iznos
                    });
                }

                return responseDto;
            }
        }

        public ErrorDto RemoveCharge(int chargeId)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Financije.Remove(db.Financije.FirstOrDefault(x => x.id_trosak == chargeId));
                db.SaveChanges();
                return new ErrorDto();
            }
        }
    }
}
