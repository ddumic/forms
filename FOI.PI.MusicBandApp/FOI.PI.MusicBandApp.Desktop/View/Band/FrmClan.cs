using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.Business.Band.Member;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.ViewModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmClan : FormHelper
    {
        private readonly IAccountManagementService _accountManagementService;
        private readonly IBandMemberManagementService _bandMemberManagementService;
        private int _memberId;

        public FrmClan(IAccountManagementService accountManagementService, IBandMemberManagementService bandMemberManagementService)
        {
            InitializeComponent();
            _accountManagementService = accountManagementService;
            _bandMemberManagementService = bandMemberManagementService;
            GetMembers();
            GetAvailableAccounts();
        }

        private void GetMembers()
        {
            members.DataSource = MapFromAccountDto(_accountManagementService.GetBandMembers(AccountHelper.GetInstance().Id));
            _memberId = int.Parse(members[0, 0].Value.ToString());
            members.RowStateChanged += ((o, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    _memberId = int.Parse(members[0, e.Row.Index].Value.ToString());
                }
            });
        }

        private void GetAvailableAccounts()
        {
            accountList.DataSource = MapToComboBoxItem(_accountManagementService.GetAccountsWithoutBand());
        }

        private void delete_Click(object sender, System.EventArgs e)
        {
            HandleResponse(_bandMemberManagementService.DeleteMember(_memberId), ResourceHelper.ResourceKey.MemberDeletedSuccessfully);
        }

        private void addMember_Click(object sender, System.EventArgs e)
        {
            HandleResponse(_bandMemberManagementService.AddMember(AccountHelper.GetInstance().Id, (accountList.SelectedItem as ComboBoxItem).Id), ResourceHelper.ResourceKey.MemberAddedSuccessfully);
        }

        #region Helper
        private List<BandMemberViewModel> MapFromAccountDto(List<AccountDto> accounts)
        {
            var responseDto = new List<BandMemberViewModel>();

            foreach (var account in accounts)
            {
                responseDto.Add(new BandMemberViewModel()
                {
                    Id = account.Id,
                    Gender = account.Gender,
                    Mail = account.Mail,
                    Name = account.Name,
                    Surname = account.Surname
                });
            }

            return responseDto;
        }

        private List<ComboBoxItem> MapToComboBoxItem(List<AccountDto> accounts)
        {
            var responseDto = new List<ComboBoxItem>();

            foreach (var account in accounts)
            {
                responseDto.Add(new ComboBoxItem()
                {
                    Id = account.Id,
                    Name = account.Name,
                    Surname = account.Surname
                });
            }

            return responseDto;
        }

        private void HandleResponse(ErrorDto response, string messge)
        {
            if (!string.IsNullOrEmpty(response.ErrorMesssage))
            {
                MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
            }
            else
            {
                MessageBoxHelper.ShowMessageBox(messge, true);
                GetMembers();
                GetAvailableAccounts();
            }
        }
        #endregion
    }
}
