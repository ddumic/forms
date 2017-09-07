using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Common.Extensions
{
    public static class InputValidationExtension
    {
        public static bool IsInputEmpty(this TextBox value)
        {
            return string.IsNullOrEmpty(value.Text);
        }
    }
}
