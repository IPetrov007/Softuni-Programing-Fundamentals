using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            var activity = new Dictionary<string, int>();
            var soldierTypesAndCounts = new Dictionary<string, Dictionary<string, long>>();

            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var lastAtcivity = int.Parse(inputLine[0]);
                var legionName = inputLine[1];
                var soldierType = inputLine[2];
                var soldierCount = long.Parse(inputLine[3]);

                if (!activity.ContainsKey(legionName))
                {
                    activity.Add(legionName, lastAtcivity);
                    soldierTypesAndCounts.Add(legionName, new Dictionary<string, long>());
                }

                if (lastAtcivity > activity[legionName])
                {
                    activity[legionName] = lastAtcivity;
                }

                if (!soldierTypesAndCounts[legionName].ContainsKey(soldierType))
                {
                    soldierTypesAndCounts[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    soldierTypesAndCounts[legionName][soldierType] += soldierCount;
                }
            }
            var finalInput = Console.ReadLine()
                .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

            if (finalInput.Length > 1)
            {
                var givenActivity = int.Parse(finalInput[0]);
                var givenSoldierType = finalInput[1];

                foreach (var item in soldierTypesAndCounts
                    .Where(l => l.Value.ContainsKey(givenSoldierType))
                    .OrderByDescending(l => l.Value[givenSoldierType]))
                {
                    if (activity[item.Key] < givenActivity)
                    {
                        Console.WriteLine($"{item.Key} -> {soldierTypesAndCounts[item.Key][givenSoldierType]}");
                    }
                }
            }
            else
            {
                var givenSoldierType = finalInput[0];
                foreach (var item in activity.OrderByDescending(x => x.Value))
                {
                    if (soldierTypesAndCounts[item.Key].ContainsKey(givenSoldierType))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }
        }
    }
}
