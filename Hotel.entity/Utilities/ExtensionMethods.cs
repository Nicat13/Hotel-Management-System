using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Utilities
{
   public static class ExtensionMethods
    {
        public static string HashPassword(this string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            string hashedpass = Convert.ToBase64String(hashBytes);
            return hashedpass;
        }
    }
}
