using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CountOccurreOfLarge
{
    class Program
    {
        static void Main(string[] args)
        {
                double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                double givenElement = double.Parse(Console.ReadLine());
                int count = 0;

                foreach (var item in arr)
                {
                    if (item > givenElement)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
       }
}