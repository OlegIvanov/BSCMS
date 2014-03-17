using System.Security.Cryptography;
using System.Text;

namespace BSCMS.Model
{
    public static class HashCalculator
    {
        public static string HashPassword(string password)
        {
            // Add salt to password
            password += "PasswordSalt";

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
