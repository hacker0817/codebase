using System.Security.Cryptography;
using System.Text;

namespace codebase
{
    public class EncryptionMD5
    {
        public static string EncryptStringMD5(string plainText)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", "").ToUpper();
            }
        }

        public static bool EqualEncryptStringMD5(string plainText, string encryptText)
        {
            bool result = false;
            if (string.IsNullOrEmpty(plainText) || string.IsNullOrEmpty(encryptText))
                return result;
            result = EncryptStringMD5(plainText).Equals(encryptText);
            return result;
        }
    }
}