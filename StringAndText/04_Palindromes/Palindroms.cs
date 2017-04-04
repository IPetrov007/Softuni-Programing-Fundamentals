

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Palindromes
{
    public class Palindroms
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var palindromes = new HashSet<string>();

            foreach (var word in input)
            {
                var reverseWord = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverseWord.Append(word[i]);
                }
                var revWord = reverseWord.ToString();
                if (revWord.Equals(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}
