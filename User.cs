using NPOI.POIFS.Crypt;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RaceManager
{
    internal class User
    {
        public enum UserType
        {
            Racegoer,
            HorseOwner,
            RaceManager
        }
        private String email;
        private String password;
        private UserType type;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        internal UserType Type { get => type; set => type = value; }

        public User()
        {
            email = "Unkown";
            password = "Unkown";
            type = UserType.Racegoer;
        }

        public User(string email, string password, UserType type)
        {
            this.email = email;
            this.password = password;
            this.type = type;
        }
        public override String ToString()
        {
            return $"Email:{email}, Password:{password}, Type:{type}";
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
    }
}
