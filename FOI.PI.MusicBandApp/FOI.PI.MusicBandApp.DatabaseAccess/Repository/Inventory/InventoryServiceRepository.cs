using FOI.PI.MusicBandApp.Contracts.Inventory;
using System.Collections.Generic;
using System.Linq;
using FOI.PI.MusicBandApp.Contracts;

namespace FOI.PI.MusicBandApp.DatabaseAccess.Repository.Inventory
{
    public class InventoryServiceRepository : IInventoryServiceRepository
    {
        public ErrorDto AddInventory(InventoryDto inventory)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.PopisOpreme.Add(new PopisOpreme()
                {
                    naziv = inventory.Name,
                    cijena = inventory.Price,
                    id_bend = inventory.BandId
                });
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public ErrorDto DeleteInventory(int inventoryId)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.PopisOpreme.Remove(db.PopisOpreme.FirstOrDefault(x => x.id_oprema == inventoryId));
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public List<InventoryDto> GetInventory(int bandId)
        {
            using (var db = new MusicBandAppEntities())
            {
                var responseDto = new List<InventoryDto>();

                foreach (var inventory in db.PopisOpreme.Where(x => x.id_bend == bandId))
                {
                    responseDto.Add(new InventoryDto()
                    {
                        BandId = inventory.id_bend,
                        Id = inventory.id_oprema,
                        Name = inventory.naziv,
                        Price = inventory.cijena
                    });
                }

                return responseDto;
            }
        }
    }
}
