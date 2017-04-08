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
            var pattern = "";
            Regex regex = new Regex(pattern);
            var result = new List<string>();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var sentence = input;
                var validSentence = regex.IsMatch(sentence);
            
                if (validSentence)
                {
                    var words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    foreach (var word in words)
                    {
                        var currentWord = word.Trim('.').Trim(',').Trim('!').Trim('?');
                        var counter = 0;
                        var index = -1;
                        while (true)
                        {
                            index = currentWord.ToLower().IndexOf(simbol, index + 1);
                            if (index > -1)
                            {
                                counter++;
                            }
                            else
                            {
                                if (counter >= digit)
                                {
                                    result.Add(currentWord);
                                }
                                counter = 0;
                                break;
                            }
                        }
                    }
                } 

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
