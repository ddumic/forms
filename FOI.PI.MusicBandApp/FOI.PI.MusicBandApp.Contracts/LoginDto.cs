using FOI.PI.MusicBandApp.Contracts.Account;
using FOI.PI.MusicBandApp.Contracts.Band;
using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts
{
    public class LoginDto
    {
        public AccountDto User { get; set; }
        public BandDto Band { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public LoginDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
