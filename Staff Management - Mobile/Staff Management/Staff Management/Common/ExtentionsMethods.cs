using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Staff_Management.Common
{
    public static class ExtentionsMethods
    {
        public static string Hash(string passwordToHash)
        {
            try
            {
                using (SHA1 sha1Hash = SHA1.Create())
                {
                    //From String to byte array
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(passwordToHash);
                    byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                    return hash;
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
