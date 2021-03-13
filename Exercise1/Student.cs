using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program: The Student Class 
 * Purpose: To hold student information
 * Coder: Sonia Friesen 0813682
 * Date: Due January 25, 2020
 */
namespace Exercises1_SF
{    
    public class Student : School
    {
        private string sFirstName;
        private string slastName;
        private string sEmail;

        //constructor
        public Student(string fName, string lName, string email)
        {
            sFirstName = fName;
            slastName = lName;
            sEmail = email;
        }
                
        /*
         * Method: ToString()
         * Purpose: to override the ToString(), to create a custom string
         * Parameters: none
         * Returns: a string
         */
        public override string ToString()
        {
            return ($"Student: {sFirstName} {slastName}, email: {sEmail}");
        }
    }
}
