using FOI.PI.MusicBandApp.Business.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Account;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band;
using System;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(new AccountManagementService(new AccountServiceRepository(), new BandServiceRepository())));
        }
    }
}
