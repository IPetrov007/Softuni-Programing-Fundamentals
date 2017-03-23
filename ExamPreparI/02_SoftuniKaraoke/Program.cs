using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(new string[] {", ", ",  "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var songs = Console.ReadLine()
                .Split(new string[] { ", ", ",  " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var awards = new Dictionary<string, int>();

            var result = new Dictionary<string, List<string>>();

            var endStr = Console.ReadLine();
            while (!endStr.Equals("dawn"))
            {
                var inputStr = endStr
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                bool isParticipantInTheList = participants.Contains(inputStr[0]);
                bool isSongInTheList = songs.Contains(inputStr[1]);
                bool isResultContainsParticipant = result.Keys.Contains(inputStr[0]);
                bool isAwardExist = result[inputStr[0]].Contains(inputStr[2]);
                if (isParticipantInTheList && isSongInTheList)
                {
                    if (!isResultContainsParticipant)
                    {
                        result[inputStr[0]] = new List<string>();
                    }
                    if (!isAwardExist)
                    {
                        result[inputStr[0]].Add(inputStr[2]);
                    }
                   
                }
                endStr = Console.ReadLine();
            }
            foreach (var str in result.Keys)
            {
                Console.WriteLine("{0}: {1}", str, result[str].Count);
                foreach (var award in result[str])
                {
                    Console.WriteLine("--{0}", award);

                }
            }
        }
    }

