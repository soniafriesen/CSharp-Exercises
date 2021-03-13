using System;
using System.Collections.Generic;
/*
 * Program: Client Program
 * Purpose: Demonstrate the understanding of Generic methods and classes with non-generic methods and classes
 * Coder: Sonia Friesen, 0813682
 * Date: Due Feb 1St 2021
 */
namespace Exercise2_SF
{
    class Program
    {
        static void Main(string[] args)
        {
            //create our two list to test the Shuffle class using the static generic method
            Console.WriteLine("Creating two List<> for testing non-generic Shuffle Class");
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            Console.WriteLine("Lists are made, now adding data\n");
           
            //list a will hold three letters in caps.
            list1.Add("ABC");
            list1.Add("DEF");
            list1.Add("GHI");
            foreach(var item in list1)
             Console.WriteLine($"Items in list1 are: {item}");

            //list 2 will hold a string of three numbers so we can visually see the shuffle 
            Console.WriteLine();
            list2.Add("123");
            list2.Add("456");
            list2.Add("789");
            foreach (var item in list2)
                Console.WriteLine($"Items in list2 are: {item}");
            
            //use the genericstatic method
            Console.WriteLine("\nUsing Shuffler generic method Shuffle()");
            List<string> list3 = Shuffler.Shuffle<string>(list1, list2); //because its static we have to add the class name.
            Console.WriteLine("Results of the new list3 after shuffle()\n");
            foreach (var item in list3)
                Console.WriteLine($"Items in list3 are: {item}");

            Console.WriteLine("\nCreating two List<> for testing generic Shuffler Class");
            List<float> list4 = new List<float>();
            List<float> list5 = new List<float>();

            Console.WriteLine("Lists are made, now adding data\n");
            //using numbers divisible by 2
            list4.Add(2.2f);
            list4.Add(4.4f);
            list4.Add(10.6f);
            foreach (var item in list4)
                Console.WriteLine($"Items in list4 are: {item}");
            Console.WriteLine();

            //using numbers divisible by 3
            list5.Add(9.9f);
            list5.Add(15.3f);
            list5.Add(21.6f);
            foreach (var item in list5)
                Console.WriteLine($"Items in list5 are: {item}");

            //using the non-generic method T: struct in GenShuffler
            Console.WriteLine("\nUsing GenShuffler ShuffleValueTypes() method");
            GenShuffler<float> genShuffler = new GenShuffler<float>();
            List<float> list6 = genShuffler.ShulffelValueTypes(list4, list5);
            Console.WriteLine("\nResults of the new list6 after ShulffelValueTypes()\n");
            foreach (var item in list6)
                Console.WriteLine($"Items in list3 are: {item}");


        }
    }
}
