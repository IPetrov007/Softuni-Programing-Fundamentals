using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CountCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            int counter = 0;

            foreach (var strings in arr)
            {
                if (strings.Length == 1 && strings[0] >= 65 && strings[0] <= 90)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
