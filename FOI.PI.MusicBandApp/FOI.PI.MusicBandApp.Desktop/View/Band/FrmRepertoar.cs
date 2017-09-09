using FOI.PI.MusicBandApp.Business.Song;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Song;
using FOI.PI.MusicBandApp.Desktop.Helper;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmRepertoar : FormHelper
    {
        private readonly ISongManagementService _songManagementService;


        public FrmRepertoar(ISongManagementService songManagementService)
        {
            InitializeComponent();
            _songManagementService = songManagementService;
        }

        private void create_Click(object sender, System.EventArgs e)
        {
            new FrmPjesma(new SongManagementService(new SongServiceRepository())).Show();
        }
    }
}
