using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CountOfNegativeEl
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

            int count = 0;
            foreach (var item in arr)
            {
                if (item <0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
