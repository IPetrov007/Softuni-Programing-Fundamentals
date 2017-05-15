using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WormTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var lenghtInCentimeters = lenght * 100;
            var remainder = lenghtInCentimeters % width;

            if (remainder == 0 || width == 0)
            {
                Console.WriteLine("{0:F2}", lenghtInCentimeters * width);
            }
            else
            {
                Console.WriteLine("{0:F2}%", (lenghtInCentimeters / width) * 100);
            }
        }
    }
}
