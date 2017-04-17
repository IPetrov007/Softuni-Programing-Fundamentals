using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var lapsForRunner = int.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            var maxRunners = days * trackCapacity;
            var participance = Math.Min(runners, maxRunners);
            var totalKilometers = (participance * lapsForRunner * trackLenght) / 1000;
            var totalMoney = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
