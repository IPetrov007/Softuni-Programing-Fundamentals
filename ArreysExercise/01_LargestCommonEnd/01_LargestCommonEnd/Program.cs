using System;
using System.Linq;

namespace _01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largestElenent = int.MinValue;

            foreach (var num in arr)
            {
                if (num > largestElenent)
                {
                    largestElenent = num;
                }
            }
            Console.WriteLine(largestElenent);
        }
    }
}
