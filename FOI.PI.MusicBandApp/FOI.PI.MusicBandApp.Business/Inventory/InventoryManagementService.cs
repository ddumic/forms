using System.Collections.Generic;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Inventory;

namespace FOI.PI.MusicBandApp.Business.Inventory
{
    public class InventoryManagementService : IInventoryManagementService
    {
        private readonly IInventoryServiceRepository _inventoryServiceRepository;

        public InventoryManagementService(IInventoryServiceRepository inventoryServiceRepository)
        {
            _inventoryServiceRepository = inventoryServiceRepository;
        }

        public ErrorDto AddInventory(InventoryDto inventory)
        {
            return _inventoryServiceRepository.AddInventory(inventory);
        }

        public ErrorDto DeleteInventory(int inventoryId)
        {
            return _inventoryServiceRepository.DeleteInventory(inventoryId);
        }

        public List<InventoryDto> GetInventory(int bandId)
        {
            return _inventoryServiceRepository.GetInventory(bandId);
        }
    }
}
