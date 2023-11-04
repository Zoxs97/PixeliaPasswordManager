using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PixeliaPasswordManager
{
    public class UserAuthentication
    {
        /// <summary>
        /// Gets the password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string HashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }

        /// <summary>
        /// Validates the user
        /// </summary>
        /// <param name="enteredPassword"></param>
        /// <param name="storedUser"></param>
        /// <returns></returns>
        public static bool AuthenticateUser(string enteredPassword, User storedUser)
        {
            if (storedUser != null)
            {
                string enteredPasswordHash = HashPassword(enteredPassword);
                return enteredPasswordHash == storedUser.MasterPasswordHash;
            }
            return false; // User not found
        }
    }
}
