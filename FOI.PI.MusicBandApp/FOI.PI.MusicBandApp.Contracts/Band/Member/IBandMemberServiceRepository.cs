namespace FOI.PI.MusicBandApp.Contracts.Band.Member
{
    public interface IBandMemberServiceRepository
    {
        ErrorDto DeleteMember(int memberId);
        ErrorDto AddMember(int bandId, int memberId);
    }
}
