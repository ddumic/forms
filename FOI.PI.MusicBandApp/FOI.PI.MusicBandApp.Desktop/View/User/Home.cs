using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Contracts.Band;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.User
{
    public partial class Home : FormHelper
    {
        private readonly IAccountManagementService _accountManagementService;
        private readonly IBandManagementService _bandManagementService;
        private int _bandId;

        public Home(IAccountManagementService accountManagementService, IBandManagementService bandManagementService)
        {
            InitializeComponent();
            _accountManagementService = accountManagementService;
            _bandManagementService = bandManagementService;
            GetAllBands();
        }

        private void odjavaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AccountHelper.Logout();
            this.Close();
        }

        private void GetAllBands()
        {
            bandList.DataSource = MapFromBandDtoList(_bandManagementService.GetAllBands());
            bandList.RowStateChanged += ((o, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    _bandId = int.Parse(bandList[0, e.Row.Index].Value.ToString());

                    UpdateFromBandDto(_bandManagementService.GetBandDetails(_bandId));

                    UpdateFromRepertoireDto(_bandManagementService.GetBandRepertoire(_bandId));
                }
            });
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            var reservation = MapFromForm();
            if (reservation.Errors.Any())
            {
                MessageBoxHelper.ShowMessageBox(reservation.Errors.First().ErrorMesssage);
            }
            else
            {
                var response = _accountManagementService.CreateReservation(reservation);
                if (!string.IsNullOrEmpty(response.ErrorMesssage))
                {
                    MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
                }
                else
                {
                    MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.ReservationSentSuccessfully, true);
                }
            }
        }

        #region Helper
        private List<BandListItemViewModel> MapFromBandDtoList(List<BandDto> bands)
        {
            var response = new List<BandListItemViewModel>();

            foreach (var band in bands)
            {
                response.Add(new BandListItemViewModel()
                {
                    Id = band.Id,
                    Name = band.Name
                });
            }

            return response;
        }

        private void UpdateFromBandDto(BandDto band)
        {
            name.Text = band.Name;
            city.Text = band.City;
            webpage.Text = band.WebPage;
            facebook.Text = band.FacebookPage;
            instagram.Text = band.InstagramPage;
            contact.Text = band.Contact;
            mail.Text = band.Mail;
            image.Image = band.Image.ToImage();
        }

        private void UpdateFromRepertoireDto(List<RepertoireDto> songs)
        {
            var repertoire = new List<RepertoireViewModel>();

            foreach (var song in songs)
            {
                repertoire.Add(new RepertoireViewModel()
                {
                    Duration = song.Duration,
                    Name = song.Name,
                    Performer = song.Performer
                });
            }

            repertoireList.DataSource = repertoire;
        }

        public ReservationDto MapFromForm()
        {
            return new ReservationDto()
            {
                DateFrom = dateFrom.Text.ToDateTime(),
                DateTo = dateTo.Text.ToDateTime(),
                BandId = _bandId,
                UserId = AccountHelper.GetInstance().Id,
                Note = note.Text,
                Errors = MapErrors()
            };
        }

        private List<ErrorDto> MapErrors()
        {
            var errorList = new List<ErrorDto>();

            if (string.IsNullOrEmpty(note.Text))
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InputFieldsMissing });

            else if (dateTo.Text.ToDateTime() < dateFrom.Text.ToDateTime())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.DateToGreaterIsThanDateFrom });

            return errorList;
        }
        #endregion

        private void pregledRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reservation(new AccountManagementService(new AccountServiceRepository(), new BandServiceRepository()), new BandManagementService(new BandServiceRepository())).Show();
        }

        private void korisničkaDokumentacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, base.GetHelpFilePath());
        }
    }
}
