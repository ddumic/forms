using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.Business.Band;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.View;
using FOI.PI.MusicBandApp.Desktop.View.Band;
using FOI.PI.MusicBandApp.Desktop.View.User;
using System.Linq;

namespace FOI.PI.MusicBandApp.Desktop
{
    public partial class Login : FormHelper
    {
        private readonly IAccountManagementService _accountManagementService;

        public Login(IAccountManagementService accountManagementService)
        {
            InitializeComponent();
            this.AcceptButton = btn_Prijava;
            _accountManagementService = accountManagementService;
        }

        private void btn_Prijava_Click(object sender, System.EventArgs e)
        {
            if (mail.IsInputEmpty() || password.IsInputEmpty())
            {
                MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.InputFieldsMissing);
            }
            else
            {
                var loginDto = _accountManagementService.Login(mail.Text, password.Text);
                if (loginDto.Errors.Any())
                {
                    MessageBoxHelper.ShowMessageBox(loginDto.Errors.First().ErrorMesssage);
                }
                else
                {
                    if (loginDto.Band.BandFounded)
                    {
                        //pokusava se logirati band
                        if (loginDto.Band.Errors.Any())
                        {
                            MessageBoxHelper.ShowMessageBox(loginDto.Band.Errors.First().ErrorMesssage);
                        }
                        else
                        {
                            //band je uspjesno logiran
                            var accountInstance = AccountHelper.GetInstance();
                            accountInstance.Id = loginDto.Band.Id;
                            accountInstance.Mail = loginDto.Band.Mail;
                            accountInstance.AccountType = loginDto.Band.AccountType;

                            var bandForm = new FrmGlavna();
                            bandForm.FormClosed += ((o, s) =>
                            {
                                this.Show();
                            });
                            this.Hide();
                            bandForm.Show();
                        }
                    }
                    else if (loginDto.User.AccountFounded)
                    {
                        //pokusava se logirati user
                        if (loginDto.User.Errors.Any())
                        {
                            MessageBoxHelper.ShowMessageBox(loginDto.User.Errors.First().ErrorMesssage);
                        }
                        else
                        {
                            //user je uspjesno logiran
                            var accountInstance = AccountHelper.GetInstance();
                            accountInstance.Id = loginDto.User.Id;
                            accountInstance.Mail = loginDto.User.Mail;
                            accountInstance.AccountType = loginDto.User.AccountType;

                            var accountForm = new Home(new BandManagementService(new BandServiceRepository()));
                            accountForm.FormClosed += ((o, s) =>
                            {
                                this.Show();
                            });
                            this.Hide();
                            accountForm.Show();
                        }
                    }
                    else
                    {
                        if (loginDto.User.Errors.Any())
                        {
                            MessageBoxHelper.ShowMessageBox(loginDto.User.Errors.First().ErrorMesssage);
                        }
                        else if (loginDto.Band.Errors.Any())
                        {
                            MessageBoxHelper.ShowMessageBox(loginDto.Band.Errors.First().ErrorMesssage);
                        }
                    }
                }
            }
        }

        private void btn_Registracija_Click(object sender, System.EventArgs e)
        {
            new Registration(new AccountManagementService(new AccountServiceRepository(), new BandServiceRepository())).Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new BandRegistration(new BandManagementService(new BandServiceRepository())).Show();
        }
    }
}
