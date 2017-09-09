using FOI.PI.MusicBandApp.Common.Resources;

namespace FOI.PI.MusicBandApp.Contracts.Validation
{
    public static class Validation
    {
        public static ErrorDto TranslateValidationStatusCode(int statusCode)
        {
            switch (statusCode)
            {
                case 1:
                    return new ErrorDto()
                    {
                        ErrorCode = 1,
                        ErrorMesssage = ResourceHelper.ResourceKey.UnknownUser
                    };
                case 2:
                    return new ErrorDto()
                    {
                        ErrorCode = 2,
                        ErrorMesssage = ResourceHelper.ResourceKey.ResultSetHasMultipleValues
                    };
                case 3:
                    return new ErrorDto()
                    {
                        ErrorCode = 3,
                        ErrorMesssage = ResourceHelper.ResourceKey.MailAlreadyTaken
                    };
                case 4:
                    return new ErrorDto()
                    {
                        ErrorCode = 4,
                        ErrorMesssage = ResourceHelper.ResourceKey.InvalidReservationStatus
                    };
                default:
                    throw new System.NotSupportedException();
            }
        }
    }
}
