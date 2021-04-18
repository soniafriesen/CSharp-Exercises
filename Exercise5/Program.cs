using System;
using System.Collections.Generic;
/*
    Program: Exercise5_SF
    Purpose: Demonstrate Extension methods understanding
    Coder: Sonia Friesen, 0813682
    Date: Due March 22nd, 2021
 */
namespace Exercise5_SF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating (a) Same two string lists in a different order");
            //list string A
            List<string> stringA = new List<string>();
            string a = "bear";
            stringA.Add(a);
            a = "fish";
            stringA.Add(a);
            a = "lizard";
            stringA.Add(a);
            //list stringB
            List<string> stringB = new List<string>();
            a = "lizard";
            stringB.Add(a);
            a = "bear";
            stringB.Add(a);
            a = "fish";
            stringB.Add(a);
            //testing CompareTo()
            Console.WriteLine($"Results from CompareTo() on (a) is: {stringA.CompareTo(stringB)}");

            //b Different two string lists with the same length
            Console.WriteLine();
            Console.WriteLine("Creating (b) Different two string lists with the same length");
            //should return false, because it has the same # of elements  (which is required logically to compare different lists) but different contains different words.
            List<string> stringC = new List<string>();
            a = "dog";
            stringC.Add(a);
            a = "cat";
            stringC.Add(a);
            a = "bird";
            stringC.Add(a);
            //testing CompareTo()
            Console.WriteLine($"Results from CompareTo() on (b) is: {stringA.CompareTo(stringC)}");

            //c. Two int lists having different lengths. For example, the first List has three elements, while the second has four
            Console.WriteLine();
            Console.WriteLine("Creating (c) Two int lists having different lengths");
            //list intA
            List<int> intA = new List<int>();
            int b = 2;
            intA.Add(b);
            b = 4;
            intA.Add(b);
            b = 6;
            intA.Add(b);
            //list intB
            List<int> intB = new List<int>();
            b = 2;
            intA.Add(b);
            b = 4;
            intA.Add(b);
            b = 6;
            intA.Add(b);
            b = 8;
            intA.Add(b);
            //testing CompareTo()
            Console.WriteLine($"Results from CompareTo() on (c) is: {intA.CompareTo(intB)}");

            //d. Two null lists.
            Console.WriteLine();
            Console.WriteLine("Creating (d) Two null lists");
            List<int> intC = new List<int>();
            List<int> intD = new List<int>();
            //testing CompareTo()
            Console.WriteLine($"Results from CompareTo() on (d) is: {intC.CompareTo(intD)}");

            //e. Two identical double lists (i.e., having the same elements following the same order)
            Console.WriteLine();
            Console.WriteLine("Creating (e) Two identical double lists");
            List<double> doubleA = new List<double>();
            double value = 2.5;
            doubleA.Add(value);
            value = 5.5;
            doubleA.Add(value);
            value = 8.5;
            doubleA.Add(value);
            List<double> doubleB = doubleA;
            //testing CompareTo()
            Console.WriteLine($"Results from CompareTo() on (e) is: {doubleA.CompareTo(doubleB)}");



        }
    }
}
