using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> Countries = Country.GetCountries();

            Console.WriteLine("============= Programming 3 - Lab 3 =============\n");
            
            Console.WriteLine("1.1 List of countries in alphabetical order\n");
            ListNamesByAlphabeticalOrder(Countries);

            Console.WriteLine("1.2 List of countries in descending order of number of resources\n");
            ListNamesByDescendingOrderResources(Countries);

            Console.WriteLine("1.3 List of countries that shares a border with Argentina\n");
            ListBorderWithArgentina(Countries);

            Console.WriteLine("1.4 List of countries that has more than 10,000,000 population\n");
            ListPopulousCountries(Countries);

            Console.WriteLine("1.5 Country with highest population\n");
            ShowMostPopulous(Countries);

            Console.WriteLine("1.6 List of all religions in south America in dictionary order\n");
            ListReligionsByAlphabeticalOrder(Countries);

            Console.ReadKey();
        }

        private static void ListNamesByAlphabeticalOrder(List<Country> _countries)
        {
            List<Country> Countries = _countries.OrderBy(c => c.Name).ToList();

            foreach (var country in Countries)
            {
                Console.WriteLine(country.Name);
            }
            Console.WriteLine("\n");
        }

        private static void ListNamesByDescendingOrderResources(List<Country> _countries)
        {
            List<Country> Countries = _countries.OrderByDescending(c => c.Resources.Count()).ToList();

            foreach (var country in Countries)
            {
                Console.WriteLine(country.Name + " - " + country.Resources.Count() + " different resources");
            }
            Console.WriteLine("\n");
        }

        private static void ListBorderWithArgentina(List<Country> _countries)
        {
            List<Country> Countries = _countries.Where(c => c.Borders.Any(b => b.Equals("Argentina"))).ToList();

            foreach (var country in Countries)
            {
                Console.WriteLine(country.Name);
            }
            Console.WriteLine("\n");
        }

        private static void ListPopulousCountries(List<Country> _countries)
        {
            List<Country> Countries = _countries.Where(c => c.Population > 10000000).ToList();

            foreach (var country in Countries)
            {
                Console.WriteLine(country.Name + " - Populatioon: " + country.Population);
            }
            Console.WriteLine("\n");
        }

        private static void ShowMostPopulous(List<Country> _countries)
        {
            Country Country = _countries.Find(c => c.Population == _countries.Max(ctry => ctry.Population));

            Console.WriteLine(Country.Name + " - Populatioon: " + Country.Population);
            Console.WriteLine("\n");
        }

        private static void ListReligionsByAlphabeticalOrder(List<Country> _countries)
        {
            List<string> Religions = new List<string> { };

            foreach (var country in _countries)
            {
                Religions.AddRange(country.Religions);
            }

            Religions = Religions.Distinct().OrderByDescending(r => r).ToList();

            foreach (var rel in Religions)
            {
                Console.WriteLine(rel);
            }

            Console.WriteLine("\n");
        }
    }
}
