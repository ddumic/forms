using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

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
                    new Bitmap(path).Save(memoryStram, ImageFormat.Png);
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

        public static Image ToImage(this byte[] blob)
        {
            using (var memoryStream = new MemoryStream())
            {
                byte[] pData = blob;
                memoryStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bitMap = new Bitmap(memoryStream, false);
                return bitMap;
            }
        }

        public static byte[] ToByteArray(this Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static double ToDouble(this string value)
        {
            double result;
            double.TryParse(value, out result);
            return result;
        }
    }
}
