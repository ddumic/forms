using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Desktop.Helper;
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
                MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.UsernameOrPasswordMissing);
            }
            else
            {
                var user = _accountManagementService.Login(mail.Text, password.Text);
                if (user.Errors.Any())
                {
                    MessageBoxHelper.ShowMessageBox(user.Errors.First().ErrorMesssage);
                }
                else
                {
                    //logiran user
                }
            }
        }

        private void btn_Registracija_Click(object sender, System.EventArgs e)
        {

        }
    }
}
