using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01_Cards
{
    public class Cards
    {
        public static void Main()
        {
            var inputStr = Console.ReadLine();
            
            //"(?<![0-9])(?:([2-9]|10)|(A|K|Q|J))+(S|H|D|C)" - matchva vsichko tochno. ne e nujen IF;

            var patern = "([1]?[0-9JKQA])([SHDC])";

            Regex regex = new Regex(patern);

            var matches = regex.Matches(inputStr);

            var result = new List<string>();

            foreach (Match match in matches)
            {
                var power = 0;

                if (int.TryParse(match.Groups[1].ToString(), out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                result.Add(match.ToString());
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
