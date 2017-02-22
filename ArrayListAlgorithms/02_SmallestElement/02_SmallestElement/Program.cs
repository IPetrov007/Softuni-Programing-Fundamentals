using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SmallestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var smallestElement = int.MaxValue;
            foreach (var element in arr)
            {
                if (element < smallestElement)
                {
                    smallestElement = element;
                }
            }
            Console.WriteLine(smallestElement);
        }
    }
}
