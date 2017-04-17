using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var participants = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();
        var songs = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();

        var awards = new Dictionary<string, int>();

        var result = new Dictionary<string, SortedSet<string>>();

        var endStr = Console.ReadLine();
        while (!endStr.Equals("dawn"))
        {
            var inputStr = endStr
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            bool isParticipantInTheList = participants.Contains(inputStr[0]);
            bool isSongInTheList = songs.Contains(inputStr[1]);
            bool isResultContainsParticipant = result.Keys.Contains(inputStr[0]);

            if (isParticipantInTheList && isSongInTheList)
            {
                if (!isResultContainsParticipant)
                {
                    result[inputStr[0]] = new SortedSet<string>();
                }
                if (!result[inputStr[0]].Contains(inputStr[2]))
                {
                    result[inputStr[0]].Add(inputStr[2]);
                }

            }
            endStr = Console.ReadLine();
        }
        result = result.OrderByDescending(x => x.Value.Count())
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        if (result.Keys.Count == 0)
        {
            Console.WriteLine("No awards");
        }
        else
        {

            foreach (var str in result.Keys)
            {
                Console.WriteLine("{0}: {1} awards", str, result[str].Count);
                foreach (var award in result[str])
                {
                    Console.WriteLine("--{0}", award);

                }
            }

        }
    }
}