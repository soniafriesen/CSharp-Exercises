using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program: User Class
 * Purpose: A object class for the client
 * Coder: Sonia Friesen, 0813682
 * Date: Due Feburary 8th 2021
 */
namespace Exercise3_SF
{
    public class User
    {
        public string loginName;
        public string password;
        public string role;
        public int transactions = 0; 

        //default constructor
        public User() { }

        //three parameter constructor
        public User(string login, string password, string role)
        {
            loginName = login;
            this.password = password;
            this.role = role;
        }        
    }
}
