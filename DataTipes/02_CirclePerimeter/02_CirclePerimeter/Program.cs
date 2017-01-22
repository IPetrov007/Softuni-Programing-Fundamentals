using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CirclePerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("{0:f12}", perimeter);
        }
    }
}
