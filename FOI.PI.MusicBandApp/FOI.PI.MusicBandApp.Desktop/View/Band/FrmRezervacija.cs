using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.ViewModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmRezervacija : FormHelper
    {
        private readonly IBandManagementService _bandManagementService;
        private int _reservationId;

        public FrmRezervacija(IBandManagementService bandManagementService)
        {
            InitializeComponent();
            _bandManagementService = bandManagementService;
            GetReservations();
            GetReservatedDates();
        }

        private void GetReservations()
        {
            requestList.DataSource = MapFromReservationDtoList(_bandManagementService.GetReservations(AccountHelper.GetInstance().Id));
            requestList.RowStateChanged += ((o, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    _reservationId = int.Parse(requestList[0, e.Row.Index].Value.ToString());
                }
            });
        }

        private void GetReservatedDates()
        {
            scheduleList.DataSource = MapFromReservationDtoList(_bandManagementService.GetReservatedDates(AccountHelper.GetInstance().Id));
        }

        private void dismiss_Click(object sender, System.EventArgs e)
        {
            HandleResult(_bandManagementService.CancelReservation(_reservationId), ResourceHelper.ResourceKey.ReservationDismissed);
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            if (price.IsInputEmpty())
                MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.PriceMissing);
            else if (!price.Text.IsInputDouble())
                MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.PriceMissing);
            else
            {
                HandleResult(_bandManagementService.SetReservationPrice(_reservationId, price.Text.ToDouble()), ResourceHelper.ResourceKey.ReservationSaved);
            }
        }

        private void HandleResult(ErrorDto response, string message)
        {
            if (!string.IsNullOrEmpty(response.ErrorMesssage))
            {
                MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
            }
            else
            {
                MessageBoxHelper.ShowMessageBox(message, true);
                GetReservations();
                GetReservatedDates();
            }
        }

        #region Helper
        private List<ReservationListItemViewModel> MapFromReservationDtoList(List<ReservationDto> reservations)
        {
            var response = new List<ReservationListItemViewModel>();

            foreach (var reservation in reservations)
            {
                response.Add(new ReservationListItemViewModel()
                {
                    Id = reservation.Id,
                    Band = reservation.BandName,
                    DateFrom = reservation.DateFrom,
                    DateTo = reservation.DateTo,
                    Status = reservation.Status,
                    Charge = reservation.Charge,
                    Note = reservation.Note
                });
            }

            return response;
        }
        #endregion
    }
}
