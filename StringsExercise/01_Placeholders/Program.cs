using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var input = inputLine
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var sentence = input[0];
                var elements = input[1]
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < elements.Length; i++)
                {
                    var placeholder = "{" + i + "}";
                    sentence = sentence.Replace(placeholder, elements[i]);
                }
                Console.WriteLine(sentence);

                inputLine = Console.ReadLine();
            }
        }
    }
}
