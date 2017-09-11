using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Finance
{
    public interface IFinanceServiceRepository
    {
        List<FinanceDto> GetBandFinanceStatus(int bandId);
        ErrorDto AddCharge(FinanceDto finance);
        ErrorDto RemoveCharge(int chargeId);
    }
}
