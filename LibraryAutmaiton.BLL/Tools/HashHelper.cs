using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.BLL.Tools
{
    public class HashHelper
    {
        public static string HashString(string text, string salt)
        {
            // Uses SHA256 to create the hash
            var sha = new System.Security.Cryptography.SHA256Managed();

            // Convert the string and the salt to a byte array first, to be processed
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            byte[] saltBytes = System.Text.Encoding.UTF8.GetBytes(salt);

            // Combine the text and the salt bytes
            byte[] combinedBytes = new byte[textBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(textBytes, 0, combinedBytes, 0, textBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, combinedBytes, textBytes.Length, saltBytes.Length);

            // Compute the hash with the salted input
            byte[] hashBytes = sha.ComputeHash(combinedBytes);

            // Convert back to a string, removing the '-' that BitConverter adds
            string hash = BitConverter
                .ToString(hashBytes)
                .Replace("-", String.Empty);

            return hash;
        }
    }
}