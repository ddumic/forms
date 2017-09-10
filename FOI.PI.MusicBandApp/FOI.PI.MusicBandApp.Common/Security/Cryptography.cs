using ArtisanCode.SimpleAesEncryption;

namespace FOI.PI.MusicBandApp.Common.Security
{
    public static class Cryptography
    {
        public static string Decrypt(this string value)
        {
            var decryptor = new RijndaelMessageDecryptor();
            return decryptor.Decrypt(value);
        }

        public static string Encrypt(this string value)
        {
            var encryptor = new RijndaelMessageEncryptor();
            return encryptor.Encrypt(value);
        }
    }
}
