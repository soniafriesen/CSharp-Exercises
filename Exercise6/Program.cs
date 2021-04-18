using Exercise_6;
using System;
using System.Collections.Generic;
/*
 * Project: Exercise 6
 * Purpose: Demonstrate LINQ operations using a List<class> as parameters
 * Coder: Sonia Friesen, 0813682
 * Date: Due March 29th, 2021
 */
namespace Exercise6_SF
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a string array
            string[] canadaSafe = { "Hi", "Canada", "Please", "Stay", "Safe" };
            Console.Write("The first character in every word in the canadaSafe string arrau using LINQ query: ");
            //var letters = LinqOrLambdaMethods.LinqFirstCharacter(canadaSafe);
            //Console.Write(letters);
            Console.WriteLine();
            Console.Write("The first character in every word in the canadaSafe string array using LING dot notation: ");
            var letters = LinqOrLambdaMethods.LambdaFirstCharacter(canadaSafe);
            Console.WriteLine(letters);

            //longest word

            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.Write("The longest word(s) using LINQ query: ");
            //letters = LinqOrLambdaMethods.LinqLongestWord(canadaSafe);
            //Console.WriteLine(letters);
            Console.WriteLine();
            Console.Write("The longest word(s) using LINQ dot notation: ");
            letters = LinqOrLambdaMethods.LambdaLongestWord(canadaSafe);
            Console.WriteLine(letters);

            //shortest word

            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.Write("The shortest word(s) using LINQ query: ");
            //letters = LinqOrLambdaMethods.LinqShortestWord(canadaSafe);
            //Console.WriteLine(letters);
            Console.WriteLine();
            Console.Write("The shortest word(s) using LINQ dot notation: ");
            letters = LinqOrLambdaMethods.LambdaShortestWord(canadaSafe);
            Console.WriteLine(letters);

            //count the number of words

            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.Write("The number of words in array using LINQ query: ");
            letters = LinqOrLambdaMethods.LinqWordsCount(canadaSafe);
            Console.WriteLine(letters);
            Console.WriteLine();
            Console.Write("The number of words in array LINQ dot notation: ");
            letters = LinqOrLambdaMethods.LambdaWordsCount(canadaSafe);
            Console.WriteLine(letters);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            //CITY Class Functions/LINQ Query
            List<City> cities = new List<City>();
            cities.Add(new City("London", "ON", 330000));
            cities.Add(new City("Toronto", "ON", 5213000));
            cities.Add(new City("Vancouver", "BC", 2313328));
            cities.Add(new City("Nelson", "BC", 11779));
            cities.Add(new City("Montreal", "QB", 3678000));
            cities.Add(new City("Québec", "QB", 624177));

            //sortedlist
            Console.WriteLine("");
            Console.WriteLine("-----------------------------CITY CLASS LINQ ---------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Sorted list of all cities");
            var sortedList = CityStatistics.SortedCities(cities);
            foreach(City c in sortedList)
            {
                Console.WriteLine(c);

            }
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Grouping cities in Provinces");
            Console.WriteLine();
            //listing by province
            var cityGroups = CityStatistics.CitiesByProvince(cities);
            foreach(var groups in cityGroups)
            {
                Console.WriteLine("Cities in Province " + groups.Key);
                Console.WriteLine("**********************");
                foreach(var city in groups)
                {
                    Console.WriteLine(city.ToString());
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Provinces with population");
            Console.WriteLine();

            //province population totals
            var provPopulationTotal = CityStatistics.ProvincesPopulation(cities);
            foreach(var province in provPopulationTotal)
            {
                Console.WriteLine(province);
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
