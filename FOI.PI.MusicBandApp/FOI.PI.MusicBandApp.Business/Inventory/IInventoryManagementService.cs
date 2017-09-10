using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Inventory;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Business.Inventory
{
    public interface IInventoryManagementService
    {
        List<InventoryDto> GetInventory(int bandId);
        ErrorDto DeleteInventory(int inventoryId);
        ErrorDto AddInventory(InventoryDto inventory);
    }
}
