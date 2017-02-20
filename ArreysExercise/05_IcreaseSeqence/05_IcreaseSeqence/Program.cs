using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IcreaseSeqence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elements = int.MinValue;
            bool IsIncreasing = true;

            foreach (var item in arr)
            {
                if (item > elements)
                {
                    elements = item;
                }
                else
                {
                    IsIncreasing = false;
                    break;
                }
            }
            if (IsIncreasing)
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
