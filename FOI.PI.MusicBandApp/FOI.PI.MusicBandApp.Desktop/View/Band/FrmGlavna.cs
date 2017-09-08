using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band;
using FOI.PI.MusicBandApp.Desktop.Helper;
using System;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmGlavna : FormHelper
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountHelper.Logout();
            this.Close();
        }
    }
}
