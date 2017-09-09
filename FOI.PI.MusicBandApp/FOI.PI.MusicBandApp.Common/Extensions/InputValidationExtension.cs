using System;
using System.Drawing;
using System.IO;
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

        public static bool IsInputNumber(this TextBox text)
        {
            int result = 0;
            return int.TryParse(text.Text, out result);
        }

        public static bool IsImagePathValid(this string value)
        {
            try
            {
                using (var memoryStram = new MemoryStream())
                {
                    new Bitmap(value).Save(memoryStram, System.Drawing.Imaging.ImageFormat.Gif);
                    memoryStram.ToArray();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsInputDouble(this string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        public static bool IsInputTimeSpan(this string value)
        {
            TimeSpan time;
            return TimeSpan.TryParse(value, out time);
        }
    }
}
