using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_WormsWorldParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^([a-zA-Z0-9 ]+) -> ([a-zA-Z0-9 ]+) -> ([0-9]+)$";
            Regex regex = new Regex(pattern);

            var names = new List<string>();
            var teams = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                var matches = regex.Match(input);
                var wormName = matches.Groups[1].Value;
                var teamName = matches.Groups[2].Value;
                var wormScore = long.Parse(matches.Groups[3].Value);

                if (names.Contains(wormName))
                {
                    continue;
                }
                else
                {
                    names.Add(wormName);
                }
                if (!teams.ContainsKey(teamName))
                {
                    teams[teamName] = new Dictionary<string, long>();
                }
                if (!teams[teamName].ContainsKey(wormName))
                {
                    teams[teamName].Add(wormName, wormScore);
                }
                else
                {
                    teams[teamName][wormName] += wormScore;
                }
            }

            teams = teams
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            var teamCount = 1;
            foreach (var team in teams)
            {
                Console.WriteLine($"{teamCount}. Team: {team.Key} - {team.Value.Values.Sum()}");
                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
                teamCount++;
            }
        }
    }
}
