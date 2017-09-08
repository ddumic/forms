using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band;

namespace FOI.PI.MusicBandApp.Business.Band
{
    public interface IBandManagementService
    {
        BandDto GetBandDetails(int id);
        ErrorDto Register(BandDto band);
        BandDto GetBand(string mail, string password);
    }
}
