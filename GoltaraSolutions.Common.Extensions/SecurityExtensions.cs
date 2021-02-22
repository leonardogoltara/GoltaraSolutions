using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace GoltaraSolutions.Common.Extensions
{
    public static class SecurityExtensions
    {
        /// <summary>
        /// Criptografia SHA1.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Encrypt(this string value)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
                hashBytes = hash.ComputeHash(encoding.GetBytes(value));

            StringBuilder hashValue = new StringBuilder(hashBytes.Length * 2);
            foreach (byte b in hashBytes)
            {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }

            return hashValue.ToString();
        }
    }
}
