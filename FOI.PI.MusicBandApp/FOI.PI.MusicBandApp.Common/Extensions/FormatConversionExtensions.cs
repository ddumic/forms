using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FOI.PI.MusicBandApp.Common.Extensions
{
    public static class FormatConversionExtensions
    {
        public static DateTime ToDateTime(this string value)
        {
            return DateTime.Parse(value);
        }

        public static byte[] ToByteArray(this string path)
        {
            try
            {
                using (var memoryStram = new MemoryStream())
                {
                    new Bitmap(path).Save(memoryStram, System.Drawing.Imaging.ImageFormat.Gif);
                    return memoryStram.ToArray();
                }
            }
            catch (Exception ex)
            {
                return new byte[0];
            }
        }

        public static int ToInt(this string value)
        {
            try
            {
                return int.Parse(value);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
