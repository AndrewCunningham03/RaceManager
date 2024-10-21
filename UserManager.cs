using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static RaceManager.User;

namespace RaceManager
{
    internal class UserManager:User
    {

        public static bool RegisterUser(User user)
        {
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            Console.WriteLine("Select user type (1: Racegoer, 2: Horse Owner, 3: Racecourse/Event Manager):");
            int userTypeInput = int.Parse(Console.ReadLine());
            if (userTypeInput > 3)
            {
                userTypeInput = 1;
            }

            string passwordHash = user.HashPassword(password);
            User newUser = new User(email, passwordHash, userTypeInput);


            using (StreamWriter writer = new StreamWriter("C:\\Users\\andre\\Documents\\Year3\\WebFrameworks\\RaceManager\\user.txt", true))
            {
                string userData = $"{newUser.Email},{newUser.Password},{newUser.UserType}";
                writer.WriteLine(userData); 
            }
            
            Console.WriteLine("User registered successfully.");
            return true;
        }
        public static bool Login(UserManager user)
        {
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            User user1 = new User();
            bool login = user.LoginUser(email, password, user1);
            if (login)
            {
                Console.WriteLine("Successfully logged in");
                return true;

            }
            return false;
        }
        public bool LoginUser(string email, string password, User user)
        {
           
            string passwordHash = HashPassword(password);
            foreach (string line in File.ReadLines("C:\\Users\\andre\\Documents\\Year3\\WebFrameworks\\RaceManager\\user.txt"))
            {
                string[] userData = line.Split(',');
                if (userData[0] == email && userData[1] == passwordHash)
                {
                    if (int.TryParse(userData[2], out int userTypeInt))
                    {
                        
                        this.Email = userData[0];
                        this.Password = userData[1];
                        this.UserType = userTypeInt; 
                        return true;
                    }
                }
            }
            return false; 
        }
        

    }

}

