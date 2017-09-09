using FOI.PI.MusicBandApp.Contracts;

namespace FOI.PI.MusicBandApp.Business.Band.Member
{
    public interface IBandMemberManagementService
    {
        ErrorDto DeleteMember(int memberId);
        ErrorDto AddMember(int bandId, int memberId);
    }
}
