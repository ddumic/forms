using FOI.PI.MusicBandApp.Business.Song;
using FOI.PI.MusicBandApp.Common.Extensions;
using FOI.PI.MusicBandApp.Common.Resources;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Song;
using FOI.PI.MusicBandApp.Desktop.Helper;
using FOI.PI.MusicBandApp.Desktop.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    public partial class FrmPjesma : FormHelper
    {
        private readonly ISongManagementService _songManagementService;

        public FrmPjesma(ISongManagementService songManagementService)
        {
            InitializeComponent();
            _songManagementService = songManagementService;
            GetGenres();
        }

        private void cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void GetGenres()
        {
            genreList.DataSource = MapToGenreViewModel(_songManagementService.GetGenres());
        }

        private void add_Click(object sender, System.EventArgs e)
        {
            var song = MapFromForm();
            if (song.Errors.Any())
            {
                MessageBoxHelper.ShowMessageBox(song.Errors.First().ErrorMesssage);
            }
            else
            {
                var response = _songManagementService.AddSong(song);
                if (!string.IsNullOrEmpty(response.ErrorMesssage))
                {
                    MessageBoxHelper.ShowMessageBox(response.ErrorMesssage);
                }
                else
                {
                    MessageBoxHelper.ShowMessageBox(ResourceHelper.ResourceKey.SongAddedSuccessfully, true);
                    this.Close();
                }
            }
        }

        #region Helper
        private List<GenreViewModel> MapToGenreViewModel(List<GenreDto> accounts)
        {
            var responseDto = new List<GenreViewModel>();

            foreach (var account in accounts)
            {
                responseDto.Add(new GenreViewModel()
                {
                    Id = account.Id,
                    Name = account.Name
                });
            }

            return responseDto;
        }

        private SongDto MapFromForm()
        {
            var song = new SongDto()
            {
                Duration = duration.Text.ToTimeSpan(),
                Genre = new GenreDto()
                {
                    Id = (genreList.SelectedItem as GenreViewModel).Id
                },
                Performer = performer.Text,
                Year = year.Text,
                Name = name.Text,
                Errors = MapErrors()
            };

            return song;
        }

        private List<ErrorDto> MapErrors()
        {
            var errorList = new List<ErrorDto>();

            if (name.IsInputEmpty()
                || performer.IsInputEmpty()
                || duration.IsInputEmpty()
                || year.IsInputEmpty())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.InputFieldsMissing });

            else if (!year.IsInputNumber())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.IncorrectNumberFormat });

            else if (!duration.Text.IsInputTimeSpan())
                errorList.Add(new ErrorDto() { ErrorMesssage = ResourceHelper.ResourceKey.IncorrectTimeSpanFormat });

            return errorList;
        }
        #endregion
    }
}
