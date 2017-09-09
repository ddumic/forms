using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.ViewModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.User
{
    public partial class Reservation : FormHelper
    {
        private readonly IAccountManagementService _accountManagementService;
        private readonly IBandManagementService _bandManagementService;

        private int _reservationId;

        public Reservation(IAccountManagementService accountManagementService, IBandManagementService bandManagementService)
        {
            InitializeComponent();
            _accountManagementService = accountManagementService;
            _bandManagementService = bandManagementService;
            GetAllReservations();
        }

        private void GetAllReservations()
        {
            reservationList.DataSource = MapFromReservationDtoList(_accountManagementService.GetAllReservations(AccountHelper.GetInstance().Id));
            _reservationId = int.Parse(reservationList[0, 0].Value.ToString());
            reservationList.RowStateChanged += ((o, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    _reservationId = int.Parse(reservationList[0, e.Row.Index].Value.ToString());
                }
            });
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
                    Charge = reservation.Charge
                });
            }

            return response;
        }
        #endregion

        private void close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void dismiss_Click(object sender, System.EventArgs e)
        {
            var response = _accountManagementService.CancelReservation(_reservationId);
            if (!string.IsNullOrEmpty(response.ErrorMesssage))
            {
                MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
            }
            else
            {
                MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.ReservationCanceledSuccessfully, true);
                this.Close();
            }
        }
    }
}
