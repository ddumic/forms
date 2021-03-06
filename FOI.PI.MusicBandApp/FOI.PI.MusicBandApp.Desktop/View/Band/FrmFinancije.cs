﻿using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Business.Finance;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Finance;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmFinancije : FormHelper
    {
        private readonly IFinanceManagementService _financeManagementService;
        private readonly IBandManagementService _bandManagementService;
        private int _chargeId;

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
            chargeList.DataSource = MapToChargeViewModel(response);

            chargeList.RowStateChanged += ((o, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    _chargeId = int.Parse(chargeList[0, e.Row.Index].Value.ToString());
                }
            });

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

        private void delete_Click(object sender, System.EventArgs e)
        {
            var response = _financeManagementService.RemoveCharge(_chargeId);
            if (!string.IsNullOrEmpty(response.ErrorMesssage))
            {
                MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
            }
            else
            {
                MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.FinanceRemovedSuccessfully, true);
                GetAllReservations();
                GetAllFinancies();
            }
        }

        #region Helper
        private IList<ChargeViewModel> MapToChargeViewModel(IList<FinanceDto> financies)
        {
            var returnDto = new List<ChargeViewModel>();

            foreach (var financy in financies)
            {
                returnDto.Add(new ChargeViewModel()
                {
                    BandId = financy.BandId,
                    Id = financy.Id,
                    Name = financy.Name,
                    Note = financy.Note,
                    Price = financy.Price
                });
            }

            return returnDto;
        }

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
