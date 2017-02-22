using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LargestNElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int N = int.Parse(Console.ReadLine());

            input.Sort();
            input.Reverse();
            var result = new List<int>();
            for (int i = 0; i < N; i++)
            {
                result.Add(input[i]);
            }
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
