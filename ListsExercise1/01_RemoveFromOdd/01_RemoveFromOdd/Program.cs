using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RemoveFromOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();
            int lenght = input.Count;

            for (int i = 0; i < (lenght/ 2); i++)
            {
                input.Remove(input[i]);
                result.Add(input[i]);
                //input.Remove(input[i]);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
