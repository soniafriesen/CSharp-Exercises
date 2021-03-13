using System;
using System.Collections.Generic;
/*
 * Program: Exercise3_SF
 * Purpose: To demonstrate understanding of Delegates using a chained Action delegate
 * Coder: Sonia Friesen, 0813682
 * Date: Due Feburary 8th 2021
 */
namespace Exercise3_SF
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            List<User> testUsers = new List<User>();
            Security security = new Security();              
            User lisa = new User("lisajone", "1234", "Admin");
            User jack = new User("jackpolar", "abcd", "Trusted");
            User ben = new User("benmore", "random", "Guest");

            //add users to list
            users.Add(lisa);
            users.Add(jack);
            users.Add(ben);
            
            foreach(User u in users)
            {
                security.InsertedUser(u);
            }
            Console.WriteLine();

            //creat new users for test use.
            //the first user I want to have the same as my "control group"
            User lisa2 = new User("lisajone", "1234", "Admin");

            //testing the same login name but different password
            User trustedUser = new User("jackpolar","acdc","Trusted"); 

            //the user with a password change
            User guestUser = new User("benmore", "notreal", "Guest");

            //user with no privlage, also not a user in the user index
            User noRole = new User("benmore", "noRole", "");

            //creating our chained delegate using the "Action"
            Action userDelegate = security.Authentication;
            userDelegate += security.Authorization;
            userDelegate += security.Auditing;
            Console.WriteLine();

            //testing "control group" Admin user Lisa1
            Console.WriteLine("Testing Admin User");
            security.SetUser(lisa2);
            userDelegate();
            Console.WriteLine();

            //testing a trusted user
            Console.WriteLine("Testing Trusted User");
            security.SetUser(trustedUser);
            userDelegate();
            Console.WriteLine();

            //testing a Guest user
            Console.WriteLine("Testing Guest User");
            security.SetUser(guestUser);
            userDelegate();
            Console.WriteLine();

            //testing a no role user
            Console.WriteLine("Testing user without a role");
            security.SetUser(noRole);
            userDelegate();
            Console.WriteLine();

            //student information
            Console.WriteLine("Exercise 3, Sonia Friesen 0813682");

        }
    }
}
