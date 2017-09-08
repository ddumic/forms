using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Account
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int? AccountType { get; set; }
        public bool AccountFounded { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public AccountDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
