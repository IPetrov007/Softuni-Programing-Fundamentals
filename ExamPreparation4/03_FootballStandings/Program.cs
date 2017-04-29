using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_FootballStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new Dictionary<string, int>();
            var goals = new Dictionary<string, int>();

            var key = Console.ReadLine();
            
            while (true)
            {
                var inputStr = Console.ReadLine();
                if (inputStr == "final")
                {
                    break;
                }

                var info = inputStr.Split().ToArray();
                
                var tim1 = info[0].Split(new string[] { key }, StringSplitOptions.None)[1].ToUpper().ToCharArray();
                var tim2 = info[1].Split(new string[] { key }, StringSplitOptions.None)[1].ToUpper().ToCharArray();
                var result = info[2].Split(':').Select(int.Parse).ToArray();

                Array.Reverse(tim1);
                Array.Reverse(tim2);

                var tim1Name = "";
                tim1Name = AddCharToName(tim1, tim1Name);
                var tim1Goals = result[0];
                var tim1Points = 0;

                var tim2Name = "";
                tim2Name = AddCharToName(tim2, tim2Name);
                var tim2Goals = result[1];
                var tim2Points = 0;

                if (tim1Goals > tim2Goals)
                {
                    tim1Points = 3;
                }
                if (tim2Goals > tim1Goals)
                {
                    tim2Points = 3;
                }
                if (tim1Goals == tim2Goals)
                {
                    tim1Points = tim2Points = 1;
                }

                AddTim(points, tim1Name, tim1Points);
                AddTim(points, tim2Name, tim2Points);
                AddTim(goals, tim1Name, tim1Goals);
                AddTim(goals, tim2Name, tim2Goals);
            }
            points = points.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x=> x.Value);
            goals = goals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            var count = 1;
            Console.WriteLine("League standings:");
            foreach (var tim in points)
            {
                Console.WriteLine($"{count}. {tim.Key} {tim.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            count = 0;
            foreach (var tim in goals)
            {
                Console.WriteLine($"- {tim.Key} -> {tim.Value}");
                count++;
                if (count == 3)
                {
                    break;
                }
            }
        }

        private static void AddTim(Dictionary<string, int> points, string tim1Name, int tim1Points)
        {
            if (!points.ContainsKey(tim1Name))
            {
                points.Add(tim1Name, tim1Points);
            }
            else
            {
                points[tim1Name] += tim1Points;
            }
        }

        private static string AddCharToName(char[] tim1, string tim1Name)
        {
            foreach (var character in tim1)
            {
                tim1Name += character;
            }

            return tim1Name;
        }
    }
}
