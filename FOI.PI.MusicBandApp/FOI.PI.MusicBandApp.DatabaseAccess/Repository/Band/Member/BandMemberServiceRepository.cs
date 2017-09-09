using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band.Member;
using System.Linq;

namespace FOI.PI.MusicBandApp.DatabaseAccess.Repository.Band.Member
{
    public class BandMemberServiceRepository : IBandMemberServiceRepository
    {
        public ErrorDto AddMember(int bandId, int memberId)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Osoba.Where(x => x.id_osoba == memberId).FirstOrDefault().id_bend = bandId;
                db.SaveChanges();
                return new ErrorDto();
            }
        }

        public ErrorDto DeleteMember(int memberId)
        {
            using (var db = new MusicBandAppEntities())
            {
                db.Osoba.Where(x => x.id_osoba == memberId).FirstOrDefault().id_bend = null;
                db.SaveChanges();
                return new ErrorDto();
            }
        }
    }
}
