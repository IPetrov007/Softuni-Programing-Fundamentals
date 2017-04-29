using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            var distance = N / 1000 * M;
            var time = (N / P * 5) + (N / 100);

            Console.WriteLine("{0:F2} m.", distance);
            Console.WriteLine("{0} s.", time);
        }
    }
}

