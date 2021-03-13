using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program: GenShuffler<T> generic class
 * Purpose: use a non-generic method in a gerneric class
 * Coder: Sonia Friesen, 0813682
 * Date: Due Feb 1St 2021
 */
namespace Exercise2_SF
{
    public class GenShuffler<T> where T : struct
    {
        public List<T> ShulffelValueTypes(List<T> a, List<T> b)
        {
            Console.WriteLine("Inside ShuffleValueTypes method to show random index.Please run more than once to see changes in index.\n");
            //shuffling using a random generator                       
            //NOTE: much better than the Shuffler.Shuffle() method.            
            List<int> randomNumList = new List<int>();
            List<T> listc = new List<T>();
            int randomNumber = 0;
            bool isRandom = false;
            int counter = 0;
            var random = new Random(); //get the random)
            while(counter < a.Count)
            {
                isRandom = false; //reset counter                 
                while (!isRandom)
                {                    
                    randomNumber = random.Next(a.Count); //get a number from 0-2 {0,1,2} or how every long the list is
                    if (!randomNumList.Contains(randomNumber))
                    {
                        Console.WriteLine($"Random index choice is: {randomNumber}");
                        randomNumList.Add(randomNumber); //add if it is not already in the list to avoid duplicated
                        isRandom = true;
                    }
                    else
                        isRandom = false;
                }
                counter++;
            }
            //add the random index to the new list
            for(int i = 0; i < a.Count; i ++)
            {
                int index = randomNumList[i];
                listc.Add(b[index]);
                listc.Add(a[index]);                
            }
            return listc;
        }
    }
}
