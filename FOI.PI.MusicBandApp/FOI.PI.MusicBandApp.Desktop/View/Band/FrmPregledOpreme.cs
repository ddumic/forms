using FOI.PI.MusicBandApp.Business.Inventory;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Inventory;
using FOI.PI.MusicBandApp.Desktop.Helper;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmPregledOpreme : FormHelper
    {
        private readonly IInventoryManagementService _inventoryManagementService;
        private int _inventoryId;

        public FrmPregledOpreme(IInventoryManagementService inventoryManagementService)
        {
            InitializeComponent();
            this.AcceptButton = add;
            _inventoryManagementService = inventoryManagementService;
            GetBandInventory();
        }

        private void GetBandInventory()
        {
            inventoryList.DataSource = _inventoryManagementService.GetInventory(AccountHelper.GetInstance().Id);
            inventoryList.RowStateChanged += ((o, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    _inventoryId = int.Parse(inventoryList[0, e.Row.Index].Value.ToString());
                }
            });
        }

        private void delete_Click(object sender, System.EventArgs e)
        {
            HandleResponse(_inventoryManagementService.DeleteInventory(_inventoryId), ResourceHelper.ResourceKey.InventoryRemovedSuccessfully);
        }

        private void add_Click(object sender, System.EventArgs e)
        {
            var inventory = MapFromForm();
            if (inventory.Errors.Any())
            {
                MessageBoxHelper.ShowMessageBox(inventory.Errors.First().ErrorMesssage);
            }
            else
                HandleResponse(_inventoryManagementService.AddInventory(inventory), ResourceHelper.ResourceKey.InventoryAddedSuccessfully);
        }

        #region Helper
        private void HandleResponse(ErrorDto response, string message)
        {
            if (!string.IsNullOrEmpty(response.ErrorMesssage))
            {
                MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
            }
            else
            {
                MessageBoxHelper.ShowMessageBox(message, true);
                GetBandInventory();
            }
        }

        private InventoryDto MapFromForm()
        {
            var inventory = new InventoryDto()
            {
                Errors = MapErrors(),
                Name = name.Text,
                Price = price.Text.ToDouble(),
                BandId = AccountHelper.GetInstance().Id
            };
            return inventory;
        }

        private List<ErrorDto> MapErrors()
        {
            var errorList = new List<ErrorDto>();

            if (name.IsInputEmpty()
                || price.IsInputEmpty())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InputFieldsMissing });

            else if (!price.Text.IsInputDouble())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InvalidPriceFormat });

            return errorList;
        }
        #endregion
    }
}
