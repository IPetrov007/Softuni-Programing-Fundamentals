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
            //([1]?[0-9JKQA])[SHDC])
            var patern = "([0-9]?[0-9JKQA])[SHDC]";

            Regex regex = new Regex(patern);

            var matches = regex.Matches(inputStr);

            var result = new List<string>();

            foreach (Match match in matches)
            {
                var power = 0;
                
                ??????????????

                if (int.TryParse(match.ToString(), out power))
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
