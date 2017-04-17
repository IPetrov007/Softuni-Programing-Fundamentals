using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(' ').ToArray();
            var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var driver in drivers)
            {
                var startFuel = (double)driver[0];
                var indexOfEmpty = -1;
                for (int i = 0; i < zones.Length; i++)
                {
                    if (!indexes.Contains(i))
                    {
                        startFuel -= zones[i];
                    }
                    else
                    {
                        startFuel += zones[i];
                    }
                    if (startFuel <= 0)
                    {
                        indexOfEmpty = i;
                        break;
                    }

                }
                if (startFuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {indexOfEmpty}");

                }
                else
                {
                    Console.WriteLine($"{driver} - fuel left {startFuel:F2}");
                }
            }
        }
    }
}
