using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] arr = text.ToCharArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    arr[i] -= (char) numbers[i];
                }
                else
                {
                    arr[i] += (char)numbers[i];
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
