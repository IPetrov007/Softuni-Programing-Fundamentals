using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CitiesByCountryAndContinent
{
    class Program
    {
        static void Main(string[] args)
        {
            var citiesData = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' });
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!citiesData.ContainsKey(continent))
                {
                    citiesData[continent] = new Dictionary<string, List<string>>();
                }
                if (!citiesData[continent].ContainsKey(country))
                {
                    citiesData[continent][country] = new List<string>();
                }
                citiesData[continent][country].Add(city);
            }
            foreach (var nameContinent in citiesData.Keys)
            {
                Console.WriteLine($"{nameContinent}:");

                foreach (var kvp in citiesData[nameContinent].Keys)
                {

                    Console.WriteLine($" {kvp} -> {string.Join(", ", citiesData[nameContinent][kvp])}");

                }
            }
        }
    }
}
