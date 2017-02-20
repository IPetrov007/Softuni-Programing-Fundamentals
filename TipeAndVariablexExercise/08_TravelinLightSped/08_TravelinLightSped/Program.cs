using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TravelinLightSped
{
    class Program
    {
        static void Main(string[] args)
        {
            double lightYears = double.Parse(Console.ReadLine());
            double allKm = lightYears * 9450000000000;


            int kmPerSeconds = 300000;
            int kmPerMinutes = kmPerSeconds * 60;//18 000 000
            int kmPerHours = kmPerMinutes * 60;  //1 080 000 000
            ulong kmPerDays = (ulong)kmPerHours * 24;    // 25 920 000 000
            ulong kmPerWeeks = kmPerDays * 7;     // 181 440 000 000


            double weeks = Math.Floor(allKm / kmPerWeeks);
            Console.WriteLine($"{weeks} weeks");

            double days = (allKm % kmPerWeeks) / kmPerDays;
            Console.WriteLine($"{Math.Floor(days)} days");

            double hours = ((allKm % kmPerWeeks) % kmPerDays) / kmPerHours;
            Console.WriteLine($"{Math.Floor(hours)} hours");

            double minutes = (((allKm % kmPerWeeks) % kmPerDays) % kmPerHours) / kmPerMinutes;
            Console.WriteLine($"{Math.Floor(minutes)} minutes");

            double seconds = ((((allKm % kmPerWeeks) % kmPerDays) % kmPerHours) % kmPerMinutes) / kmPerSeconds;
            Console.WriteLine($"{Math.Floor(seconds)} seconds");




        }
    }
}
