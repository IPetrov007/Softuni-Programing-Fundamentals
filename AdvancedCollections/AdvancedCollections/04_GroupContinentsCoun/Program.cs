using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupContinentsCountriesCities
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                AddNewInput(result, continent, country, city);

            }

            foreach (var continent in result.Keys)
            {
                Console.WriteLine($"{continent}:");
                foreach (var country in result[continent].Keys)
                {
                    Console.Write("  {0} ->", country);
                    Console.WriteLine(" {0}", string.Join(", ", result[continent][country]));

                }
            }
        }

        private static void AddNewInput(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> result, string continent, string country, string city)
        {
            if (!result.ContainsKey(continent))
            {
                result[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!result[continent].ContainsKey(country))
            {
                result[continent][country] = new SortedSet<string>();
            }
            result[continent][country].Add(city);
        }
    }
}
