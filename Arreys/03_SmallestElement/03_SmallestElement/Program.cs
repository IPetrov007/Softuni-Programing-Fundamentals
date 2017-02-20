using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SmallestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int smallest = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < smallest)
                {
                    smallest = nums[i];
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
