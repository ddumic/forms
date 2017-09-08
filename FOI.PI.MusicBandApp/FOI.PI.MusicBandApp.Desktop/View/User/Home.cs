using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Contracts.Band;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.User
{
    public partial class Home : FormHelper
    {
        private readonly IBandManagementService _bandManagementService;

        public Home(IBandManagementService bandManagementService)
        {
            InitializeComponent();
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
                    UpdateFromBandDto(_bandManagementService.GetBandDetails(int.Parse(bandList[0, e.Row.Index].Value.ToString())));

                    UpdateFromRepertoireDto(_bandManagementService.GetBandRepertoire(int.Parse(bandList[0, e.Row.Index].Value.ToString())));
                }
            });
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
            image.Image = ByteToImage(band.Image);
        }

        private Bitmap ByteToImage(byte[] blob)
        {
            using (var memoryStream = new MemoryStream())
            {
                byte[] pData = blob;
                memoryStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bitMap = new Bitmap(memoryStream, false);
                return bitMap;
            }
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
        #endregion
    }
}
