using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DistanceOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            long laithYear = 9450000000000;
            decimal distanceToProximaCentauri = 4.22M * laithYear;
            decimal distanceToMilkyWay = 26000m * laithYear;
            decimal diameturOfMilkyWay = 100000m * laithYear;
            decimal distanceToUbservalUniverse = 46500000000m * laithYear;

            Console.WriteLine("{0:e2}", distanceToProximaCentauri);
            Console.WriteLine("{0:e2}", distanceToMilkyWay);
            Console.WriteLine("{0:e2}", diameturOfMilkyWay);
            Console.WriteLine("{0:e2}", distanceToUbservalUniverse);

        }
    }
}
