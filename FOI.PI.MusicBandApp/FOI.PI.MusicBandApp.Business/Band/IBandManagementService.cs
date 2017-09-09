using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Business.Band
{
    public interface IBandManagementService
    {
        BandDto GetBandDetails(int id);
        ErrorDto Register(BandDto band);
        BandDto GetBand(string mail, string password);
        List<BandDto> GetAllBands();
        List<RepertoireDto> GetBandRepertoire(int bandId);
        ErrorDto DeleteBand(int bandId);
        ErrorDto UpdateBand(BandDto band);

    }
}
