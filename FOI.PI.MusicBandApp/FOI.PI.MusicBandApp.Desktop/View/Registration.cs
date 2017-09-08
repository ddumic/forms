using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Desktop.Helper;
using System.Collections.Generic;
using System.Linq;

namespace FOI.PI.MusicBandApp.Desktop.View
{
    public partial class Registration : FormHelper
    {
        private readonly IAccountManagementService _accountManagementService;

        public Registration(IAccountManagementService accountManagementService)
        {
            InitializeComponent();
            this.AcceptButton = register;
            _accountManagementService = accountManagementService;
        }

        private void cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void register_Click(object sender, System.EventArgs e)
        {
            var account = MapFromForm();
            if (account.Errors.Any())
            {
                MessageBoxHelper.ShowMessageBox(account.Errors.First().ErrorMesssage);
            }
            else
            {
                var response = _accountManagementService.Register(account);
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

        private AccountDto MapFromForm()
        {
            var account = new AccountDto()
            {
                Address = address.Text,
                City = city.Text,
                Gender = gender.Text,
                Mail = mail.Text,
                Name = name.Text,
                Surname = surname.Text,
                Password = password.Text,
                Errors = MapErrors()
            };

            return account;
        }

        private List<ErrorDto> MapErrors()
        {
            var errorList = new List<ErrorDto>();

            if (name.IsInputEmpty()
                || surname.IsInputEmpty()
                || address.IsInputEmpty()
                || city.IsInputEmpty()
                || gender.IsComboBoxItemSelected()
                || mail.IsInputEmpty()
                || password.IsInputEmpty())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InputFieldsMissing });

            else if (!mail.IsInputMail())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.IncorrectEmailFormat });

            return errorList;
        }
        #endregion
    }
}
