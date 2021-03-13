using System;
using System.Collections;
/*
 * Program: The GenericList Class 
 * Purpose: To create a custom list class to accept any type
 * Coder: Sonia Friesen 0813682
 * Date: Due January 25, 2020
 */
namespace Exercises1_SF
{
    public class GenericList<T>
    {
        T[] gList = new T[10];
        private int count = 0;

      /*
       * Method: Clear()
       * Purpose: to add object to the list
       * Parameters: none
       * Returns: none
       */
        public void Clear()
        {
            gList = new T[10];
            count = 0;            
        }
        
       /*
        * Method: GetItem()
        * Purpose: to add object to the list
        * Parameters: none
        * Returns: none
        */
        public T GetItem(int index)
        {
            if (index > 10)
                throw new ArgumentOutOfRangeException($"Item out of range {index}");
            else
                return gList[index];
        }
       /*
        * Method: Add()
        * Purpose: to add object to the list
        * Parameters: none
        * Returns: none
        */
        public void Add(T item)
        {
            if (count < 11)
                gList[count++] = item;
            else
                throw new ArgumentOutOfRangeException($"Out of range {count}");
        }
       /*
        * Method: Insert()
        * Purpose: to add object to the list
        * Parameters: none
        * Returns: none
        */
        public void Insert(int index,T item)
        {
            if (index > 10)
                throw new ArgumentOutOfRangeException($"Out of range {count}");
            else 
            {
                if (gList[index] == null)
                     gList[index] = item;
                else 
                {
                    T element = item;
                    T previous = gList[index];
                    int counter = index;
                    for(int i = 0; i < count; i ++)
                    {
                        if (counter > gList.Length)
                            throw new ArgumentOutOfRangeException($"Value went out of range, index inserted was {index}");
                        else
                        {
                            //collect the current element in the occupied space                          
                            gList[counter] = element;
                            //increment the counter
                            counter++;
                            //do some swaping of elements
                            element = previous;
                            previous = gList[counter];                            
                        }
                    }
                }
            }
            count++;
        }

        public void Remove(int index)
        {
            if (index > gList.Length)
                throw new ArgumentOutOfRangeException($"Out of range {index}");
            if (gList[index] == null)
                throw new ArgumentNullException($"Element at {index} does not exist");
            else
            {
                int counter = index;
                //the element being removed
                for(int i = 0; i < count; i ++)
                {
                    gList[counter] = gList[counter+1];
                    counter++;
                }
            }
            count--;
        }
        //define an indexer to allow the client code to use [] notation
        public T this[int index]
        {
            get { return gList[index]; }
            set { gList[index] = value; }
        }
        //Enable the foreach statement
        public IEnumerator GetEnumerator()
        {
            return gList.GetEnumerator();
        }
    }
}
