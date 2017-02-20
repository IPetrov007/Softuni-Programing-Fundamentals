using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_COuntGivenElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenElement = int.Parse(Console.ReadLine());
            int count = 0;

            foreach (var item in arr)
            {
                if (item == givenElement)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
