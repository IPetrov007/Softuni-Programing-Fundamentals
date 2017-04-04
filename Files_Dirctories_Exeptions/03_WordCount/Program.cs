using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWords = File.ReadAllText("words.txt").ToLower().Split(' ').ToList();

            var inputText = File.ReadAllText("text.txt").ToLower().Split(new[] { ' ', '-', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = new Dictionary<string, int>();
            foreach (var word in inputWords)
            {
                foreach (var str in inputText)
                {
                    if (!result.ContainsKey(word))
                    {
                        result.Add(word, 0);
                    }
                    if (word.Equals(str))
                    {
                        result[word]++;
                    }
                }
            }
            foreach (var kvp in result.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
