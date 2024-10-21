using NPOI.POIFS.Crypt;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static com.sun.tools.@internal.xjc.reader.xmlschema.bindinfo.BIConversion;

namespace RaceManager
{
    internal class User
    {
      
        private String email;
        private String password;
        private int userType;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int UserType { get => userType; set => userType = value; }

        public User()
        {

        }

        public User(string email, string password, int userType)
        {
            this.email = email;
            this.password = password;
            this.UserType = userType;
        }
        public override String ToString()
        {
            return $"Email:{email}, Password:{password}, Type:{userType}";
        }

        public string HashPassword(string password)
        {
            byte[] saltBytes = Encoding.UTF8.GetBytes("NotSoSecretSalt");
            int iterations = 10000;
            int keySize = 256;

            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations))
            {
                byte[] hashBytes = pbkdf2.GetBytes(keySize / 8);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   email == user.email &&
                   password == user.password &&
                   userType == user.userType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(email, password, userType);
        }
    }
}
