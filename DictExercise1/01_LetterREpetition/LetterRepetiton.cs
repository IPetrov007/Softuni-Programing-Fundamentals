using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LetterREpetition
{
    class LetterRepetiton
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new Dictionary<char, int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result.Add(input[i], 0);
                }
                result[input[i]]++;
            }

            foreach (var kvp in result.Keys)
            {
                Console.WriteLine($"{kvp} -> {result[kvp]}");
            }
        }
    }
}
