using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var uniqueCharacters = new HashSet<char>();

            foreach (var item in input)
            {
                uniqueCharacters.Add(item);
            }

            var result = string.Empty;

            foreach (var itemChar in uniqueCharacters)
            {
                result += itemChar + ":";
                var index = input.IndexOf(itemChar, 0);
                while (index >= 0)
                {
                    result += index + "/";
                    index = input.IndexOf(itemChar, index + 1);
                }
                Console.WriteLine(result.Trim('/'));
                result = string.Empty;
            }
        }
    }
}
