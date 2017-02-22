using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var j = i + 1;

                while (j > 0)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    j--;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
