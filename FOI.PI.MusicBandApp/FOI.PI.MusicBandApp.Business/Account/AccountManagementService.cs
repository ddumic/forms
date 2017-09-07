using FOI.PI.MusicBandApp.Contracts.Account;
using System.Linq;
using FOI.PI.MusicBandApp.Contracts.Validation;
using FOI.PI.MusicBandApp.Contracts;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Business.Account
{
    public class AccountManagementService : IAccountManagementService
    {
        private readonly IAccountServiceRepository _accountServiceRepository;
        public AccountManagementService(IAccountServiceRepository accountServiceRepository)
        {
            _accountServiceRepository = accountServiceRepository;
        }

        public AccountDto Login(string mail, string password)
        {
            var user = _accountServiceRepository.Login(mail, password);
            var translatedErrors = new List<ErrorDto>();
            if (user.Errors.Any())
            {
                foreach (var error in user.Errors)
                    translatedErrors.Add(Validation.TranslateValidationStatusCode(error.ErrorCode));
            }
            user.Errors = translatedErrors;
            return user;
        }
    }
}
