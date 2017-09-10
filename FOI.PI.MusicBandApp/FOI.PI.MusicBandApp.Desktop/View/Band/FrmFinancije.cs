using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Business.Finance;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Finance;
using FOI.PI.MusicBandApp.Desktop.Helper;
using System.Collections.Generic;
using System.Linq;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmFinancije : FormHelper
    {
        private readonly IFinanceManagementService _financeManagementService;
        private readonly IBandManagementService _bandManagementService;

        public FrmFinancije(IFinanceManagementService financeManagementService, IBandManagementService bandManagementService)
        {
            InitializeComponent();
            _financeManagementService = financeManagementService;
            _bandManagementService = bandManagementService;
            GetAllReservations();
            GetAllFinancies();
        }

        private void GetAllReservations()
        {
            var response = _bandManagementService.GetReservatedDates(AccountHelper.GetInstance().Id);
            reservtionCharge.Text = response.Sum(x => x.Charge.Value).ToString();
        }

        private void GetAllFinancies()
        {
            var response = _financeManagementService.GetBandFinanceStatus(AccountHelper.GetInstance().Id);
            chargeList.DataSource = response;
            chargeCount.Text = response.Sum(x => x.Price.Value).ToString();
            diff.Text = (double.Parse(reservtionCharge.Text) - double.Parse(chargeCount.Text)).ToString();
        }

        private void add_Click(object sender, System.EventArgs e)
        {
            var fiance = MapFromForm();
            if (fiance.Errors.Any())
            {
                MessageBoxHelper.ShowMessageBox(fiance.Errors.First().ErrorMesssage);
            }
            else
            {
                var response = _financeManagementService.AddCharge(fiance);
                if (!string.IsNullOrEmpty(response.ErrorMesssage))
                {
                    MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
                }
                else
                {
                    MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.FinanceAddedSuccessfully, true);
                    GetAllReservations();
                    GetAllFinancies();
                }
            }
        }

        #region Helper
        private FinanceDto MapFromForm()
        {
            var fiance = new FinanceDto()
            {
                Name = name.Text,
                Note = note.Text,
                Price = price.Text.ToDouble(),
                BandId = AccountHelper.GetInstance().Id,
                Errors = MapErrors()
            };

            return fiance;
        }

        private List<ErrorDto> MapErrors()
        {
            var errorList = new List<ErrorDto>();

            if (name.IsInputEmpty()
                || price.IsInputEmpty()
                || string.IsNullOrEmpty(note.Text))
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InputFieldsMissing });

            else if (!price.Text.IsInputDouble())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InvalidPriceFormat });


            return errorList;
        }
        #endregion
    }
}
