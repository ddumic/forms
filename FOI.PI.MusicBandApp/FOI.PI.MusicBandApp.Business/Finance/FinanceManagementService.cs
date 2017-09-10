using System.Collections.Generic;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Finance;

namespace FOI.PI.MusicBandApp.Business.Finance
{
    public class FinanceManagementService : IFinanceManagementService
    {
        private readonly IFinanceServiceRepository _financeServiceRepository;

        public FinanceManagementService(IFinanceServiceRepository financeServiceRepository)
        {
            _financeServiceRepository = financeServiceRepository;
        }

        public ErrorDto AddCharge(FinanceDto finance)
        {
            return _financeServiceRepository.AddCharge(finance);
        }

        public List<FinanceDto> GetBandFinanceStatus(int bandId)
        {
            return _financeServiceRepository.GetBandFinanceStatus(bandId);
        }
    }
}
