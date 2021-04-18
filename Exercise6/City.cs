using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Project: Exercise 6
 * Purpose: Demonstrate LINQ operations using a List<class> as parameters
 * Coder: Sonia Friesen, 0813682
 * Date: Due March 29th, 2021
 */
namespace Exercise6_SF
{
    //City Object Class
    public class City
    {
        public string Name { get; set; }
        public string Province { get; set; }
        public int Population { get; set; }

        //constructor
        public City(string name, string province, int population)
        {
            Name = name;
            Province = province;
            Population = population;
        }
        //override method ToString
        public override string ToString()
        {
            return Name;
        }
    }

    //CityStatistics static class
    public static class CityStatistics
    {
        /*
         * Method:SortedCities
         * Pupose: Use LINQ Query to sort list by city
         * Parameters:List<City>
         * Returns: IEnumerable<City>
         */
        public static IEnumerable<City> SortedCities(List<City> cities)
        {
            var sortedList = from city in cities
                             orderby city.Name ascending
                             select city;
            return sortedList;
        }
        /*
        * Method:CitiesByProvince
        * Pupose: Use LINQ Query to sort list by Province
        * Parameters:List<City>
        * Returns: IEnumerable<IGrouping<string, City>>
        */
        public static IEnumerable<IGrouping<string, City>> CitiesByProvince(List<City> cities)
        {
            var groupedList = from city in cities
                              group city by city.Province into ProvGroups
                              orderby ProvGroups.Key
                              select ProvGroups;
            return groupedList;
        }
        /*
        * Method:ProvincesPopulation
        * Pupose: Use LINQ Query to get province total population
        * Parameters:List<City>
        * Returns: Array
        */
        public static Array ProvincesPopulation(List<City> cities)
        {
            var provinceList = from city in cities
                               group city by city.Province into ProvGroups
                               select new
                               {
                                   Province = ProvGroups.Key,
                                   TotalPopulation = (from c in ProvGroups
                                                      select c.Population).Sum()
                               };
            return provinceList.ToArray();
        }
    }
}
