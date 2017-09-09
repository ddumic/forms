using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Business.Band.Member;
using FOI.PI.MusicBandApp.Business.Song;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band.Member;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Song;
using FOI.PI.MusicBandApp.Desktop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmGlavna : FormHelper
    {
        private readonly IBandManagementService _bandManagementService;

        public FrmGlavna(IBandManagementService bandManagementService)
        {
            InitializeComponent();
            _bandManagementService = bandManagementService;
            GetBandData();
        }

        private void GetBandData()
        {
            MapFromBandDto(_bandManagementService.GetBandDetails(AccountHelper.GetInstance().Id));
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountHelper.Logout();
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var response = _bandManagementService.DeleteBand(AccountHelper.GetInstance().Id);
            if (!string.IsNullOrEmpty(response.ErrorMesssage))
            {
                MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
            }
            else
            {
                MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.BandDeletedSuccessfully, true);
                AccountHelper.Logout();
                this.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            var band = MapFromForm();
            if (band.Errors.Any())
            {
                MessageBoxHelper.ShowMessageBox(band.Errors.First().ErrorMesssage);
            }
            else
            {
                var response = _bandManagementService.UpdateBand(band);
                if (!string.IsNullOrEmpty(response.ErrorMesssage))
                {
                    MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
                }
                else
                {
                    MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.BandUpdatedSuccessfully, true);
                    GetBandData();
                }
            }
        }

        #region Helper
        public void MapFromBandDto(BandDto band)
        {
            city.Text = band.City;
            contact.Text = band.Contact;
            facebook.Text = band.FacebookPage;
            founded.Text = band.Founded.ToString();
            imageBox.Image = band.Image.ToImage();
            instagram.Text = band.InstagramPage;
            mail.Text = band.Mail;
            memberCount.Text = band.MemberCount.ToString();
            name.Text = band.Name;
            webPage.Text = band.WebPage;
        }

        private BandDto MapFromForm()
        {
            var band = new BandDto()
            {
                City = city.Text,
                Contact = contact.Text,
                FacebookPage = facebook.Text,
                Founded = founded.Text.ToDateTime(),
                InstagramPage = instagram.Text,
                Mail = mail.Text,
                MemberCount = memberCount.Text.ToInt(),
                Name = name.Text,
                Password = password.Text,
                WebPage = webPage.Text,
                Id = AccountHelper.GetInstance().Id,
                Image = imageBox.Image.ToByteArray(),
                Errors = MapErrors()
            };

            return band;
        }

        private List<ErrorDto> MapErrors()
        {
            var errorList = new List<ErrorDto>();

            if (name.IsInputEmpty()
                || memberCount.IsInputEmpty()
                || city.IsInputEmpty()
                || webPage.IsInputEmpty()
                || facebook.IsInputEmpty()
                || instagram.IsInputEmpty()
                || contact.IsInputEmpty()
                || mail.IsInputEmpty()
                || password.IsInputEmpty())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InputFieldsMissing });

            else if (!mail.IsInputMail())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.IncorrectEmailFormat });

            else if (!memberCount.IsInputNumber())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.IncorrectNumberFormat });

            return errorList;
        }
        #endregion

        private void pregledRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRezervacija(new BandManagementService(new BandServiceRepository())).Show();
        }

        private void članoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmClan(new AccountManagementService(new AccountServiceRepository(), new BandServiceRepository()), new BandMemberManagementService(new BandMemberServiceRepository())).Show();
        }

        private void repertoarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRepertoar(new SongManagementService(new SongServiceRepository())).Show();
        }
    }
}
