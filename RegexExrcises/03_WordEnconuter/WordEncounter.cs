using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_WordEnconuter
{
    public class WordEncounter
    {
        public static void Main()
        {
            var filter = Console.ReadLine().ToArray();
            var simbol = filter[0];
            var digit = int.Parse(filter[1].ToString());
            var pattern = @"[A-Z].*[.!?]";
            Regex regex = new Regex(pattern);
            var result = new List<string>();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var sentence = input;
                var validSentence = regex.IsMatch(sentence);
            
                if (validSentence)
                {
                    var patternWord = new Regex(@"\w+");

                    var words = patternWord.Matches(sentence);
                    foreach (Match word in words)
                    {
                        var currentWord = word.Groups[0].Value;
                        var counter = 0;

                        foreach (var character in currentWord)
                        {
                            if (character == simbol)
                            {
                                counter++;
                            }
                        }
                        if (counter >= digit)
                        {
                            result.Add(currentWord);
                        }
                        counter = 0;
                    }
                } 
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
