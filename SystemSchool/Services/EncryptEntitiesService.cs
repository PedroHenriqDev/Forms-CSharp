using System;
using System.Security.Cryptography;
using System.Text;

namespace Services
{
    /// <summary>
    /// Provides methods for encrypting entities.
    /// </summary>
    public class EncryptEntitiesService
    {
        /// <summary>
        /// Encrypts the specified password using SHA512 algorithm.
        /// </summary>
        /// <param name="password">The password to encrypt.</param>
        /// <returns>The encrypted password.</returns>
        internal string EncryptPasswordSHA512(string password)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha512.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < Math.Min(hashBytes.Length, 50 / 2); i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
