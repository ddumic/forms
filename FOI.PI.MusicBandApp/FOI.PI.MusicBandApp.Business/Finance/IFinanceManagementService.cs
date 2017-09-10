using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Finance;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Business.Finance
{
    public interface IFinanceManagementService
    {
        List<FinanceDto> GetBandFinanceStatus(int bandId);
        ErrorDto AddCharge(FinanceDto finance);
    }
}
