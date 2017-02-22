using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrayContainsElemn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int element = int.Parse(Console.ReadLine());

            var containsElement = false;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == element)
                {
                    containsElement = true;
                    break;
                }

            }
            if (containsElement)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
                

        }
    }
}
