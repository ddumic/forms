using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Inventory
{
    public interface IInventoryServiceRepository
    {
        List<InventoryDto> GetInventory(int bandId);
        ErrorDto DeleteInventory(int inventoryId);
        ErrorDto AddInventory(InventoryDto inventory);
    }
}
