using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WormHole
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var count = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] == 0)
                {
                    count++;
                }
                else
                {
                    var index = integers[i];
                    integers[i] = 0;
                    i = index - 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
