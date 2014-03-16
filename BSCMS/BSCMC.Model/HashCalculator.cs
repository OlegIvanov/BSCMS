using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace BSCMS.Model
{
    public static class HashCalculator
    {
        public static string HashPassword(string password)
        {
            // Take salt for password
            string passwordSalt = "";

            // Add salt to password
            password += passwordSalt;

            // Convert password to bytes
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Create sha provider
            var cryptoServiceProvider = new SHA1CryptoServiceProvider();

            // Get hash from password
            passwordBytes = cryptoServiceProvider.ComputeHash(passwordBytes);

            // Convert hash to string
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var passwordByte in passwordBytes)
            {
                stringBuilder.Append(passwordByte.ToString("x2").ToLower());
            }
            return stringBuilder.ToString();
        }
    }
}
