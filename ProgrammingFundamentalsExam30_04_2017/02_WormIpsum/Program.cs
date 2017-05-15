using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_WormIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^[A-Z](.+)\.$";
            
            Regex regex = new Regex(pattern);

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Worm Ipsum")
                {
                    break;
                }
                if (!regex.IsMatch(inputLine))
                {
                    continue;
                }
                var match = regex.Match(inputLine);

                var inputStr = match.Value.ToString();

                var patternMoreSentenses = @"([A-Z](.+)\.) ";
                var regexSent = new Regex(patternMoreSentenses);
                if (regexSent.IsMatch(inputStr))
                {
                    continue;
                }

                var sentence = match.Value.TrimEnd('.').Split().ToArray();

                for (int i = 0; i < sentence.Length; i++)
                {
                    var word = sentence[i];
                    var occurences = new Dictionary<char, int>();
                    var str = word.TrimEnd('.').ToCharArray();

                    var maxCharacter = '0';
                    foreach (var character in str)
                    {
                        if (!occurences.ContainsKey(character))
                        {
                            occurences.Add(character, 1);
                        }
                        else
                        {
                            occurences[character]++;
                        }
                        if (occurences[character] == occurences.Values.Max())
                        {
                            maxCharacter = character;
                        }
                    }
                    var maxOccurences = occurences.Values.Max();
                    if (maxOccurences > 1)
                    {
                        sentence[i] = new string(maxCharacter, str.Length);
                    }
                    
                }
                Console.WriteLine(string.Join(" ", sentence) + ".");
            }

            
        }
    }
}
