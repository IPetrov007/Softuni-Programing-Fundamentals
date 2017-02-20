using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            while (grapes.Count > growthDays)
            {

                for (int currentRound = 0; currentRound < growthDays; currentRound++)
                {
                    IncrementAllGrapes(grapes);


                    for (int i = 0; i < grapes.Count; i++)
                    {
                        GrowingForDay(grapes, i);
                    }


                }
                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] <= growthDays)
                    {
                        grapes.RemoveAt(i);
                        i--;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", grapes));
        }

        private static void IncrementAllGrapes(List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                grapes[i]++;
            }
        }

        private static void GrowingForDay(List<int> grapes, int i)
        {
            var isFirstElement = i == 0;
            var isLastElement = i == grapes.Count - 1;

            if (!isFirstElement && !isLastElement)
            {
                var previosIndex = i - 1;
                var nextIndex = i + 1;

                var isGreaterThanPrevious = grapes[i] > grapes[previosIndex];
                var isGraterThanNext = grapes[i] > grapes[nextIndex];

                var isGraterGrape = isGreaterThanPrevious && isGraterThanNext;

                if (isGraterGrape)
                {
                    grapes[i]--;

                    if (grapes[previosIndex] > 0)
                    {
                        grapes[i]++;
                        grapes[previosIndex] = Math.Max(grapes[previosIndex] - 2, 0);
                    }
                    if (grapes[nextIndex] > 0)
                    {
                        grapes[i]++;
                        grapes[nextIndex] = Math.Max(grapes[nextIndex] - 2, 0);
                    }
                }
            }
        }
    }
}
