using System;
using System.Collections.Generic;
using System.Linq;


namespace _06_WineCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int growthDays = int.Parse(Console.ReadLine());
            
            while (grapes.Count >= growthDays)
            {
                int days = 0;
                GrowingGrapes(grapes, growthDays, days);
                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] <= growthDays)
                    {
                        grapes.Remove(grapes[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", grapes));
        }

        private static List<int> GrowingGrapes(List<int> grapes, int growthDays, int days)
        {
            while (days < growthDays)
            {
                for (int i = 0; i < grapes.Count; i++)
                {
                    grapes[i]++;
                }
                for (int j = 1; j < grapes.Count - 1; j++)
                {
                    if ((grapes[j] > grapes[j - 1]) && (grapes[j] > grapes[j + 1]))
                    {
                        grapes[j]--;
                        if (grapes[j - 1] > 0)
                        {
                            grapes[j]++;
                        }
                        if (grapes[j + 1] > 0)
                        {
                            grapes[j]++;
                        }
                        grapes[j - 1] = Math.Max(grapes[j - 1] - 2, 0);
                        grapes[j + 1] = Math.Max(grapes[j + 1] - 2, 0);

                    }
                }
                days++;
            }

            return grapes;
        }
    }
}
