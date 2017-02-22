using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ReverseElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int firstElement = 0; firstElement < arr.Count/2; firstElement++)
            {
                var temp = arr[firstElement];
                arr[firstElement] = arr[arr.Count - firstElement - 1];
                arr[arr.Count - firstElement - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
