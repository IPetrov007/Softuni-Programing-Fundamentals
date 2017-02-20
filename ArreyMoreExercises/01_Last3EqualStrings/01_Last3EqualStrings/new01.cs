using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Last3EqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            string lastEqual = arr[arr.Length - 1];
            //int count = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i].Equals(lastEqual))
                {
                    count++;
                }
                lastEqual = arr[i];
                if (count == 3)
                {
                    Console.WriteLine($"{lastEqual } {lastEqual } {lastEqual}");
                    break;
                }
            }
        }
    }
}
