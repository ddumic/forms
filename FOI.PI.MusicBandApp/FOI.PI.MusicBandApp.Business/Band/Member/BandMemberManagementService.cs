using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band.Member;
using FOI.PI.MusicBandApp.Contracts.Validation;
using System;

namespace FOI.PI.MusicBandApp.Business.Band.Member
{
    public class BandMemberManagementService : IBandMemberManagementService
    {
        private readonly IBandMemberServiceRepository _bandMemberServiceRepository;

        public BandMemberManagementService(IBandMemberServiceRepository bandMemberServiceRepository)
        {
            _bandMemberServiceRepository = bandMemberServiceRepository;
        }

        public ErrorDto AddMember(int bandId, int memberId)
        {
            try
            {
                var response = _bandMemberServiceRepository.AddMember(bandId, memberId);
                if (response.ErrorCode.HasValue)
                    return Validation.TranslateValidationStatusCode(response.ErrorCode.Value);
                return response;
            }
            catch (Exception ex)
            {
                return new ErrorDto()
                {
                    ErrorMesssage = ex.Message
                };
            }
        }

        public ErrorDto DeleteMember(int memberId)
        {
            try
            {
                var response = _bandMemberServiceRepository.DeleteMember(memberId);
                if (response.ErrorCode.HasValue)
                    return Validation.TranslateValidationStatusCode(response.ErrorCode.Value);
                return response;
            }
            catch (Exception ex)
            {
                return new ErrorDto()
                {
                    ErrorMesssage = ex.Message
                };
            }
        }
    }
}
