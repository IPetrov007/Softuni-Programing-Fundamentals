using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hours = int.Parse(Console.ReadLine());

            int[] hourForTesting = new int[capacity.Length];
            for (int i = 0; i < capacity.Length; i++)
            {
                hourForTesting[i] = 1;
            }
            double[] restCapacity = new double[capacity.Length];
            SetRestCapacityElements(capacity, restCapacity);

            SetCapacity(restCapacity, usagePerHour, hours, hourForTesting);

            double[] percentage = new double[capacity.Length];
            for (int i = 0; i < capacity.Length; i++)
            {
                percentage[i] = (restCapacity[i] * 100) / capacity[i];
            }

            PrintResult(restCapacity, percentage, hourForTesting);
        }

        private static void SetRestCapacityElements(double[] capacity, double[] restCapacity)
        {
            for (int i = 0; i < restCapacity.Length; i++)
            {
                restCapacity[i] = capacity[i];
            }
        }

        private static void SetCapacity(double[] restCapacity, double[] usagePerHour, int hours, int[] hourForTesting)
        {
            for (int l = 0; l < hours; l++)
            {
                for (int i = 0; i < restCapacity.Length; i++)
                {
                    restCapacity[i] = restCapacity[i] - usagePerHour[i];
                    if (restCapacity[i] > 0)
                    {
                        hourForTesting[i]++;
                    }
                }
            }
        }

        private static void PrintResult(double[] restCapacity, double[] percentage, int[] hourForTesting)
        {
            for (int j = 0; j < restCapacity.Length; j++)
            {
                if (restCapacity[j] > 0)
                {
                    Console.WriteLine($"Battery {j + 1}: {restCapacity[j]:F2} mAh ({percentage[j]:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {j + 1}: dead (lasted {hourForTesting[j]} hours)");
                }

            }
        }
    }
}
