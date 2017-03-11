using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var k = input.Length / 4;

            var firstPartUpper = input
                .Take(k)
                .Reverse()
                .ToArray();
            var secondPartUpper = input
                .Reverse()
                .Take(k)
                .ToArray();
            var upperPart = firstPartUpper.Concat(secondPartUpper).ToArray();
            var lowerPart = input
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            for (int i = 0; i < upperPart.Length; i++)
            {
                var sum = upperPart[i] + lowerPart[i];
                Console.Write(sum + " ");
               
            }
            Console.WriteLine();

        }
    }
}
