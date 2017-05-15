using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_WormIpsum2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Worm Ipsum")
                {
                    break;
                }
                var inputStr = inputLine.TrimEnd('.');

                if (inputStr.Contains("."))
                {
                    var indexOfDot = inputStr.IndexOf('.');
                    var isNextCharIsSpace = inputStr[indexOfDot + 1] == ' ';
                    var isTheNextCharIsUpper = char.IsUpper(inputStr[indexOfDot + 2]);
                    if (isNextCharIsSpace && isTheNextCharIsUpper)
                    {
                        continue;
                    }

                }
                
                var sentence = inputStr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (!char.IsUpper(sentence[0].ToCharArray()[0]))
                {
                    continue;
                }
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
