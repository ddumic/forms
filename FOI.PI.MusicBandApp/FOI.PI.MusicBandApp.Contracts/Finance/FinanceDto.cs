using System.Collections.Generic;

namespace FOI.PI.MusicBandApp.Contracts.Finance
{
    public class FinanceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public double? Price { get; set; }
        public int BandId { get; set; }
        public IList<ErrorDto> Errors { get; set; }

        public FinanceDto()
        {
            Errors = new List<ErrorDto>();
        }
    }
}
