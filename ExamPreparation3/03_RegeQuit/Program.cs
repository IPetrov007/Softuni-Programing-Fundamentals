using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            //var uniqueString = new HashSet<string>();
            //foreach (var currChar in inputString)
            //{
            //    if (!(currChar >= 48 && currChar <= 57))
            //    {
            //        uniqueString.Add(currChar.ToString().ToUpper());
            //    }

            //}
            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    var currentChar = inputString[i].ToString().ToUpper();
            //    //var num = -1;
            //    if (currentChar.ToCharArray()[0] >= 48 && currentChar[0]<=57)
            //        //!int.TryParse(currentChar.ToString(), out num))
            //    {
                    
            //    }
            //}
            //uniqueString.Distinct().ToList();

            var pattern = @"([^\d]+)(\d{1,2})";
            var regex = new Regex(pattern);

            var matches = regex.Matches(inputString);

            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var currentString = match.Groups[1].Value.ToUpper();
                var currentCount = int.Parse(match.Groups[2].Value);
                if (currentCount <= 20)
                {
                    for (int i = 0; i < currentCount; i++)
                    {
                        sb.Append(currentString);
                    }
                 }
            }
            var uniqueString = sb.ToString().Distinct().ToList();
            Console.WriteLine($"Unique symbols used: {uniqueString.Count}");
            Console.WriteLine(sb.ToString());
        }
    }
}
