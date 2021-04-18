using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
/*
    Program: ListExtensions static class
    Purpose: Single method to compare two lists of type T(anything)
    Coder: Sonia Friesen, 0813682
    Date: Due March 22nd, 2021
 */
namespace Exercise5_SF
{
    public static class ListExtensions
    {
        //Compares two lists, returns true or false
        public static bool CompareTo<T>(this List<T> a, List<T> b)
        {
            //false return is list a has more or less elements than list b
            if (a.Count != b.Count)
                return false;
            //returns true to both null
            if (a.Count == 0 && b.Count == 0)
                return true;            
            else //they have the same length, lets check the values 
            {
                bool contains = false;
                //checks if item in a is in list b
                foreach (T item in a)
                {
                    if (b.Contains(item))
                        contains = true; //if all the values are in both list the same, does not matter order
                    else
                        contains = false; //if one is not the same, its returns false
                }
                if (contains == false) //checking the contains bool variable
                    return false;
                else return true; //all good, return true
            }            
        }
    }
}
