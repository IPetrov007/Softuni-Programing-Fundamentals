using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var counts = new SortedDictionary<double, int>();

            foreach (var str in input)
            {
                double num = double.Parse(str);

                if (!counts.ContainsKey(num))
                {
                    counts[num] = 0;
                }
                counts[num]++;
            }

            foreach (var kvp in counts)
            {
                //int a = kvp.Value;
                //var times = a == 1 ? "time" : "times";
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
