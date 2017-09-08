using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band;
using System;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.AccountHelper.Logout();
            new Login(new AccountManagementService(new AccountServiceRepository(), new BandServiceRepository())).Show();
            this.Close();
        }
    }
}
