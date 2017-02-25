using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SortArrOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 0; i < input.Count - 1; i++)
                {
                    var present = input[i];
                    var next = input[i + 1];
                    
                    if ((present.CompareTo(next) == 1))
                    {
                        var temp = input[i];
                        input[i] = input[i+1];
                        input[i + 1] = temp;
                        unsorted = true;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
