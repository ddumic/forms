using FOI.PI.MusicBandApp.Contracts.Account;
using System.Linq;
using FOI.PI.MusicBandApp.Contracts.Validation;
using FOI.PI.MusicBandApp.Contracts;
using System.Collections.Generic;
using System;
using FOI.PI.MusicBandApp.Contracts.Band;

namespace FOI.PI.MusicBandApp.Business.Account
{
    public class AccountManagementService : IAccountManagementService
    {
        private readonly IAccountServiceRepository _accountServiceRepository;
        private readonly IBandServiceRepository _bandServiceRepository;

        public AccountManagementService(IAccountServiceRepository accountServiceRepository, IBandServiceRepository bandServiceRepository)
        {
            _accountServiceRepository = accountServiceRepository;
            _bandServiceRepository = bandServiceRepository;
        }

        public LoginDto Login(string mail, string password)
        {
            //If user exists
            var user = _accountServiceRepository.Login(mail, password);
            var translatedErrors = new List<ErrorDto>();
            if (user.Errors.Any())
            {
                foreach (var error in user.Errors)
                    translatedErrors.Add(Validation.TranslateValidationStatusCode(error.ErrorCode.Value));
            }
            user.Errors = translatedErrors;

            //If band exists
            var band = _bandServiceRepository.GetBand(mail, password);
            translatedErrors = new List<ErrorDto>();
            if (band.Errors.Any())
            {
                foreach (var error in band.Errors)
                    translatedErrors.Add(Validation.TranslateValidationStatusCode(error.ErrorCode.Value));
            }
            band.Errors = translatedErrors;

            var responseDto = new LoginDto()
            {
                User = user,
                Band = band
            };

            if (band.BandFounded && user.AccountFounded)
            {
                responseDto.Errors.Add(Validation.TranslateValidationStatusCode((int)ValidationStatusCode.ResultsetHasMoreItems));
            }

            return responseDto;
        }

        public ErrorDto Register(AccountDto account)
        {
            try
            {
                var response = _accountServiceRepository.Register(account);
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
