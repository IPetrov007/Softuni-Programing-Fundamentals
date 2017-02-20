using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> output = new List<int>();

            output.Add(input[0]);
       
            for (int i = 1; i < input.Count - 1; i++)
            {
                output.Add(input[input.Count - 1 - i]);
            }
            output.Add(input[input.Count - 1]);

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
