using System.Resources;

namespace FOI.PI.MusicBandApp.Desktop.Helper
{
    public static class TranslationHelper
    {
        public static string GetTranslatedValue(string key)
        {
            ResourceManager resourceManager = new ResourceManager("FOI.PI.MusicBandApp.Desktop.Resources.hr-HR", typeof(Login).Assembly);
            var translatedValue = resourceManager.GetString(key);
            if (string.IsNullOrEmpty(translatedValue))
                return key;
            return translatedValue;
        }
    }
}
