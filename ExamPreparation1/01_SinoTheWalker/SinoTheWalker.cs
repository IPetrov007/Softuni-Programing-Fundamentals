using System;

namespace TimeDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            DateTime startTime = DateTime.Parse(input);

            var steps = int.Parse(Console.ReadLine()) % 86400;
            var secondsPerStep = int.Parse(Console.ReadLine()) % 86400;
            var allTimeInSeconds = (steps * secondsPerStep);

            TimeSpan spanTime = TimeSpan.FromSeconds(allTimeInSeconds);

            var result = startTime + spanTime;

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}