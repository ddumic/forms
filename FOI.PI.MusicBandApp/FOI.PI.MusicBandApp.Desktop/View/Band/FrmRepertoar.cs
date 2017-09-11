using FOI.PI.MusicBandApp.Business.Song;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Song;
using FOI.PI.MusicBandApp.DatabaseAccess.Repository.Song;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.ViewModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmRepertoar : FormHelper
    {
        private readonly ISongManagementService _songManagementService;
        private int _selectedSong;


        public FrmRepertoar(ISongManagementService songManagementService)
        {
            InitializeComponent();
            _songManagementService = songManagementService;
            GetBandSongs();
            GetAvailableSongs();
        }

        private void create_Click(object sender, System.EventArgs e)
        {
            var createSong = new FrmPjesma(new SongManagementService(new SongServiceRepository()));

            createSong.FormClosed += ((o, s) =>
              {
                  GetBandSongs();
                  GetAvailableSongs();
              });
            createSong.Show();
        }

        private void GetBandSongs()
        {
            bandSongs.DataSource = MapToSongViewModel(_songManagementService.GetBandSongs(AccountHelper.GetInstance().Id));
            bandSongs.RowStateChanged += ((o, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    _selectedSong = int.Parse(bandSongs[0, e.Row.Index].Value.ToString());
                }
            });
        }

        private void GetAvailableSongs()
        {
            songList.DataSource = MapToSongViewModel(_songManagementService.GetAvailableSongs(AccountHelper.GetInstance().Id));
        }

        private void add_Click(object sender, System.EventArgs e)
        {
            HandleResponse(_songManagementService.AddBandSong(AccountHelper.GetInstance().Id, (songList.SelectedItem as BaseViewModel).Id), ResourceHelper.ResourceKey.SongAddedSuccessfully);
        }

        private void delete_Click(object sender, System.EventArgs e)
        {
            HandleResponse(_songManagementService.DeleteSong(AccountHelper.GetInstance().Id, _selectedSong), ResourceHelper.ResourceKey.SongRemovedSuccessfully);
        }

        #region Helper
        private void HandleResponse(ErrorDto response, string message)
        {
            if (!string.IsNullOrEmpty(response.ErrorMesssage))
            {
                MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
            }
            else
            {
                MessageBoxHelper.ShowMessageBox(message, true);
                GetBandSongs();
                GetAvailableSongs();
            }
        }
        private List<BaseViewModel> MapToSongViewModel(List<SongDto> songs)
        {
            var responseDto = new List<BaseViewModel>();

            foreach (var song in songs)
            {
                responseDto.Add(new BaseViewModel()
                {
                    Id = song.Id,
                    Name = song.Name
                });
            }

            return responseDto;
        }
        #endregion
    }
}
