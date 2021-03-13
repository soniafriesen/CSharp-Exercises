using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program: Shuffler non-generic class
 * Purpose: use a generic method in a non-gerneric class
 * Coder: Sonia Friesen, 0813682
 * Date: Due Feb 1St 2021
 */
namespace Exercise2_SF
{
    public class Shuffler
    {
        public static List<T> Shuffle<T>(List<T> a, List<T> b)
        {
            int listLength = a.Count * 2; //getting the total length of the new List<T> 
            List<T> shuffledList = new List<T>();
            int j = a.Count-1;            
            for(int i = 0; i < a.Count; i ++)
            {                
                //first swap the values in a and b 
                T temp = a[i];
                a[i] = b[i];
                b[i] = temp;
                
                //Than simply shuffle, adding just every other element from list a and b 
                //BUT in reverse order.
                shuffledList.Add(a[j]); //add a
                shuffledList.Add(b[j]); //add b
                j--;
                //list should be {a,b,a,b,a,b,a,b,a,b,a,b} etc of how many long it is
                //simple but not the best way to shuffle, the generic class will have a better way
            } 
            return shuffledList;            
        }  
    }
}
