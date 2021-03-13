using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Program: The Professor Class 
 * Purpose: Class object to hold a professors information
 * Coder: Sonia Friesen 0813682
 * Date: Due January 25, 2020
 */
namespace Exercises1_SF
{
    public class Professor: School
    {
        private string pFirstName ;
        private string pLastName;
        private string pEmail;
        private string hireDate;

        //constructor
        public Professor(string fname,string lname, string email, string hire)
        {
            pFirstName = fname;
            pLastName = lname;
            pEmail = email;
            hireDate = hire;
        }

        /*
        * Method: ToString()
        * Purpose: to override the ToString(), to create a custom string
        * Parameters: none
        * Returns: a string
        */
        public override string ToString()
        {
            return ($"Professor: {pFirstName} {pLastName}, email: {pEmail}, date hired: {hireDate}");
        }
    }
}
