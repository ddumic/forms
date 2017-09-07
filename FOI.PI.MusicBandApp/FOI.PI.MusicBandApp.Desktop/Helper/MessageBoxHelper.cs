using FOI.PI.MusicBandApp.Common.Resources;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Desktop.Helper
{
    public static class MessageBoxHelper
    {
        public static void ShowMessageBox(string title, string text)
        {
            MessageBox.Show(TranslationHelper.GetTranslatedValue(text), TranslationHelper.GetTranslatedValue(title));
        }

        public static void ShowMessageBox(string text)
        {
            MessageBox.Show(TranslationHelper.GetTranslatedValue(text)
                , TranslationHelper.GetTranslatedValue(ResourceHelper.ResourceKey.Error)
                , MessageBoxButtons.OK
                , MessageBoxIcon.Error);
        }
    }
}
