using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            byte result = (byte)n;

            int overflows = n / 256;

            Console.WriteLine(result);
            if (overflows > 0)
            {
                Console.WriteLine($"Overflowed {overflows} times");
            }

            
        }
    }
}
