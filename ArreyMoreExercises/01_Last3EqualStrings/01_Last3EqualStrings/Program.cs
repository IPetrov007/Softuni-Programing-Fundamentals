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

            string result = string.Empty;
            int count = 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i].Equals(result))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                result = arr[i];
                if (count == 3)
                {
                    Console.WriteLine($"{result } {result } {result}");
                    break;
                }
            }
        }
    }
}
