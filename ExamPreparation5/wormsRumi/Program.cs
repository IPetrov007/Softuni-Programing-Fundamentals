using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, long>>();
            var line = Console.ReadLine();
            while (line != "quit")
            {
                var tokens = line.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var wName = tokens[0];
                var teamName = tokens[1];
                var score = long.Parse(tokens[2]);
                var hasW = false;
                foreach (var kvp in result)
                {
                    if (kvp.Value.ContainsKey(wName))
                    {
                        hasW = true;
                    }
                }
                if (!hasW)
                {

                    if (!result.ContainsKey(teamName))
                    {
                        result[teamName] = new Dictionary<string, long>();
                    }
                    if (!result[teamName].ContainsKey(wName))
                    {
                        result[teamName].Add(wName, 0L);

                    }
                    result[teamName][wName] += score;
                }
                line = Console.ReadLine();
            }
            var count = 1;
            foreach (var kvp in result.OrderByDescending(x => x.Value.Sum(y => y.Value))
               .ThenByDescending(x => x.Value.Sum(y => y.Value) / x.Value.Count()))

            {

                var totalScore = kvp.Value.Sum(x => x.Value);
                Console.WriteLine("{0}. Team: {1} - {2}", count, kvp.Key, totalScore);
                count++;
                foreach (var wNameScore in kvp.Value.OrderByDescending(x => x.Value))
                {
                    var wName = wNameScore.Key;
                    var score = wNameScore.Value;
                    Console.WriteLine("###{0} : {1}", wName, score);
                }
            }
        }
    }
}