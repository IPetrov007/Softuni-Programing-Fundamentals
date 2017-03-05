using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');
            var result = new Dictionary<string, int>();

            foreach (var str in input)
            {
                if (!result.ContainsKey(str))
                {
                    result[str] = 0;
                }
                result[str]++;
            }

            var oddResult = new List<string>();
            foreach (var kvp in result)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddResult.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddResult));
        }
    }
}
