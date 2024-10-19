using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
