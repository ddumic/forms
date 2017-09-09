using System;
using FOI.PI.MusicBandApp.Contracts;
using FOI.PI.MusicBandApp.Contracts.Band;
using System.Linq;
using System.Collections.Generic;
using FOI.PI.MusicBandApp.Contracts.Validation;

namespace FOI.PI.MusicBandApp.Business.Band
{
    public class BandManagementService : IBandManagementService
    {
        private readonly IBandServiceRepository _bandServiceRepository;

        public BandManagementService(IBandServiceRepository bandServiceRepository)
        {
            _bandServiceRepository = bandServiceRepository;
        }

        public List<BandDto> GetAllBands()
        {
            return _bandServiceRepository.GetAllBands();
        }

        public BandDto GetBand(string mail, string password)
        {
            var band = _bandServiceRepository.GetBand(mail, password);
            var translatedErrors = new List<ErrorDto>();
            if (band.Errors.Any())
            {
                foreach (var error in band.Errors)
                    translatedErrors.Add(Validation.TranslateValidationStatusCode(error.ErrorCode.Value));
            }
            band.Errors = translatedErrors;
            return band;
        }

        public BandDto GetBandDetails(int id)
        {
            var band = _bandServiceRepository.GetBandDetails(id);
            var translatedErrors = new List<ErrorDto>();
            if (band.Errors.Any())
            {
                foreach (var error in band.Errors)
                    translatedErrors.Add(Validation.TranslateValidationStatusCode(error.ErrorCode.Value));
            }
            band.Errors = translatedErrors;
            return band;
        }

        public ErrorDto Register(BandDto band)
        {
            try
            {
                var response = _bandServiceRepository.Register(band);
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

        public List<RepertoireDto> GetBandRepertoire(int bandId)
        {
            return _bandServiceRepository.GetBandRepertoire(bandId);
        }

    }
}
