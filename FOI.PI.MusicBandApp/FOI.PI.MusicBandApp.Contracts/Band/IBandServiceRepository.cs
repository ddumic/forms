namespace FOI.PI.MusicBandApp.Contracts.Band
{
    public interface IBandServiceRepository
    {
        BandDto GetBandDetails(int id);
        ErrorDto Register(BandDto band);
        BandDto GetBand(string mail, string password);
    }
}
