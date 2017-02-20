using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DistingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            List<int> distinct = input.Distinct().ToList();

            Console.WriteLine(string.Join(" ", distinct));
        }
    }
}
