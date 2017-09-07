using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Common.Extensions
{
    public static class InputValidationExtension
    {
        public static bool IsInputEmpty(this TextBox value)
        {
            return string.IsNullOrEmpty(value.Text);
        }

        public static bool IsInputMail(this TextBox value)
        {
            try
            {
                MailAddress mail = new MailAddress(value.Text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsComboBoxItemSelected(this ComboBox value)
        {
            return string.IsNullOrEmpty(value.Text);
        }
    }
}
