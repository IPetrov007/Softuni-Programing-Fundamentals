using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace CubicWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(\d+)([a-zA-Z]+)([^a-zA-Z]+)?$";
            var input = Console.ReadLine();
            while (input != "Over!")
            {
                var ismatch = Regex.IsMatch(input, pattern);
                MatchCollection matches = Regex.Matches(input, pattern);
                if (!ismatch)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var m = int.Parse(Console.ReadLine());
                var word = matches[0].Groups[2].Value;
                if (word.Length != m)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var leftandrightpart = (matches[0].Groups[1].Value + matches[0].Groups[3].Value).ToCharArray();
                Console.Write(word + " == ");

                var s = word.ToCharArray();
                var result = string.Empty;
                for (int i = 0; i < leftandrightpart.Length; i++)
                {
                    if (!char.IsDigit(leftandrightpart[i]))
                    {
                        result += " ";
                        continue;
                    }
                    var index = int.Parse((leftandrightpart[i]).ToString());
                    if (index >= s.Length)
                    {
                        result += " ";
                        continue;
                    }
                    else
                    {
                        result += s[index];
                    }
                }
                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}