using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_EqualSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int element = arr[1];
            bool isTheSame = true;

            foreach (var item in arr)
            {
                if (item != element)
                {
                   isTheSame = false;
                   break;
                }
            }
            if (isTheSame)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
