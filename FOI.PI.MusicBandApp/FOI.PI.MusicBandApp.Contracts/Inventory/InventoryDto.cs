using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Inventory
{
    public class InventoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int BandId { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public InventoryDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
