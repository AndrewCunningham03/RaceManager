using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RaceManager
{
    internal class UserManager
    {
        private string filePath = "users.txt";

        User user = new User();

        public void RegisterUser(User user)
        {
            string userData = $"{user.Email},{user.HashPassword},{user.Type}";
            File.AppendAllText(filePath, userData + Environment.NewLine);
        }

        public bool LoginUser(string email, string password)
        {
            string passwordHash = user.HashPassword(password);
            foreach (string line in File.ReadLines(filePath))
            {
                string[] userData = line.Split(',');
                if (userData[0] == email && userData[1] == passwordHash)
                {
                    return true; 
                }
            }
            return false; 
        }
        

    }

}

