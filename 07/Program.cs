using System;
using System.Collections.Generic;
using System.Linq;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> countryPopulation = new Dictionary<string, long>();

            Dictionary<string, Dictionary<string, long>> cityPopulation = new Dictionary<string, Dictionary<string, long>>();

            string[] input = Console.ReadLine().Split("|");


            while (true)

            {
                if (input[0] == "report")
                {
                    break;
                }

                string country = input[1];
                string city = input[0];
                long population = long.Parse(input[2]);


                if (countryPopulation.ContainsKey(country) == false)
                {
                    countryPopulation.Add(country, 0);
                    cityPopulation.Add(country, new Dictionary<string, long>());
                }

                countryPopulation[country] += population;
                cityPopulation[country].Add(city, population);

                input = Console.ReadLine().Split("|");
            }

            foreach (var country in countryPopulation.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                Dictionary<string, long> cities = cityPopulation[country.Key]
                    .OrderByDescending(c => c.Value)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }

            }

            Console.WriteLine();

        }
    }
}