using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program: Secruity Class
 * Purpose: A class to simulate a login system 
 * Coder: Sonia Friesen, 0813682
 * Date: Due Feburary 8th 2021
 */
namespace Exercise3_SF
{
    public class Security
    {
        private List<User> _registeredUsers = new List<User>();
        private User _testedUser;
        public delegate void userDelegate(); 

        public void InsertedUser(User user)
        {
            _registeredUsers.Add(user);
            Console.WriteLine("User added: {0} , Role: {1}", user.loginName, user.role);
        }
        public void SetUser(User user)
        {
            _testedUser = user;
        }
        public void Authentication()
        {
           bool found = false;
           foreach(User user in _registeredUsers)
            {
                if(user.loginName == _testedUser.loginName)
                {
                    found = true;
                    if (_testedUser.loginName == user.loginName && _testedUser.password == user.password)
                    {
                        Console.WriteLine("Login successful for user {0}.", _testedUser.loginName);
                        //return true;
                    }

                    else if (_testedUser.loginName == user.loginName && _testedUser.password != user.password)
                    {
                        Console.WriteLine("Login unsuccessful for user {0}, check password.", _testedUser.loginName);
                        //return false;
                    }
                    break;
                }
            }
           if(!found)
            {
                Console.WriteLine("User does not exist!");
            }
        }
        public void Authorization()
        {
            int index = 0;
            switch (_testedUser.role)
            {
                case "Admin":
                    Console.WriteLine("Admin: All privileges are granted!");
                    //find where in the _registeredUsers is this user to increment the transactions
                    index = _registeredUsers.FindIndex(a => a.loginName == _testedUser.loginName);
                    _registeredUsers[index].transactions += 3;
                    index = 0; //reset index
                    break;
                case "Trusted":
                    Console.WriteLine("Trusted: Read/write privileges are granted!");
                    //find where in the _registeredUsers is this user to increment the transactions
                     index = _registeredUsers.FindIndex(a => a.loginName == _testedUser.loginName);
                    _registeredUsers[index].transactions += 2;
                    index = 0;//reset index
                    break;
                case "Guest":
                    Console.WriteLine("Guest: Read privileges are granted!");
                    //find where in the _registeredUsers is this user to increment the transactions
                    index = _registeredUsers.FindIndex(a => a.loginName == _testedUser.loginName);
                    _registeredUsers[index].transactions += 1;
                    index = 0;//reset index
                    break;
                default:
                    Console.WriteLine("No privileges have assigned to this user {0}.", _testedUser.loginName);
                    //find where in the _registeredUsers is this user to increment the transactions
                    index = _registeredUsers.FindIndex(a => a.loginName == _testedUser.loginName);
                    _registeredUsers[index].transactions += 0;
                    index = 0;//reset index
                    break;
            }
        }
        public void Auditing()
        {
            //if (_registeredUsers.Contains(_testedUser)) would not work 
            //{
            //    int index = _registeredUsers.FindIndex(a => a.loginName == _testedUser.loginName);
            //    User user = _registeredUsers[index];
            //    Console.WriteLine("User {0} had {1} valid/invalid transcations.", user.loginName, user.transactions);
            //}
            //else
            //    Console.WriteLine("User does not exist.");

            bool found = false;
            foreach (User user in _registeredUsers)
            {
                if (user.loginName == _testedUser.loginName)
                {
                    found = true;
                    int index = _registeredUsers.FindIndex(a => a.loginName == _testedUser.loginName);
                    User registeredUser = _registeredUsers[index];
                    Console.WriteLine("User {0} had {1} valid/invalid transcations.", registeredUser.loginName, registeredUser.transactions);
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("User does not exist!");
            }
        }

    }
}
