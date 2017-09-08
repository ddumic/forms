using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band;
using FOI.PI.MusicBandApp.Desktop.Helper;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View
{
    public partial class BandRegistration : FormHelper
    {
        private readonly IBandManagementService _bandManagementService;

        public BandRegistration(IBandManagementService bandManagementService)
        {
            InitializeComponent();
            this.AcceptButton = register;
            _bandManagementService = bandManagementService;
        }

        private void cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void load_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                image.Text = open.FileName;
            }
        }

        private void register_Click(object sender, System.EventArgs e)
        {
            var band = MapFromForm();
            if (band.Errors.Any())
            {
                MessageBoxHelper.ShowMessageBox(band.Errors.First().ErrorMesssage);
            }
            else
            {
                var response = _bandManagementService.Register(band);
                if (!string.IsNullOrEmpty(response.ErrorMesssage))
                {
                    MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
                }
                else
                {
                    MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.RegisteredSuccessfully, true);
                    this.Close();
                }
            }
        }

        #region Helper
        private BandDto MapFromForm()
        {
            var band = new BandDto()
            {
                City = city.Text,
                Contact = contact.Text,
                FacebookPage = facebook.Text,
                Founded = founded.Text.ToDateTime(),
                Image = image.Text.ToByteArray(),
                InstagramPage = instagram.Text,
                Mail = mail.Text,
                MemberCount = memberCount.Text.ToInt(),
                Name = name.Text,
                Password = password.Text,
                WebPage = webPage.Text,
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
                || password.IsInputEmpty()
                || image.IsInputEmpty())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InputFieldsMissing });

            else if (!mail.IsInputMail())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.IncorrectEmailFormat });

            else if (!memberCount.IsInputNumber())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.IncorrectNumberFormat });

            else if (!image.Text.IsImagePathValid())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.ImageNotValid });

            return errorList;
        }
        #endregion
    }
}