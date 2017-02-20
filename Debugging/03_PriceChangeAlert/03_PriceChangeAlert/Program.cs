using System;

namespace _03_PriceChangeAlert
{

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double change = double.Parse(Console.ReadLine());
            double firstPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine());

                double difference = DiffInPercents(firstPrice, nextPrice);

                bool isSignificantDifference = IsDifferent(difference, change);

                string message = GetOutput(nextPrice, firstPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                firstPrice = nextPrice;
            }
        }

        static string GetOutput(double nextPrice, double lastPrice, double difference, bool isSignificantDifference)
        {
            string result = string.Empty;
            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", nextPrice);
            }
            else if (!isSignificantDifference)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, nextPrice, difference);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, nextPrice, difference);
            }
            else if (isSignificantDifference && (difference < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, nextPrice, difference);
            return result;
        }
        static bool IsDifferent(double difference, double change)
        {
            if (Math.Abs(difference) >= (change * 100))
            {
                return true;
            }
            return false;
        }

        static double DiffInPercents(double firstPrice, double nextPrice)
        {
            double result = ((nextPrice - firstPrice) / firstPrice) * 100;
            return result;
        }
    }
}