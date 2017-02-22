using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InsertionUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (input[j] < input[j - 1])
                    {
                        input.Insert(j - 1, input[j]);
                        input.RemoveAt(j + 1);
                    }
                    j--;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
