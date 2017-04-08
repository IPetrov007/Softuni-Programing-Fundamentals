using System;
using System.Text.RegularExpressions;

namespace _02_Fish
{
    public class Fish
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"(>*)<(\(+)([\'-]|x)>";
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            if (!regex.IsMatch(input))
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
            var count = 1;
                foreach (Match match in matches)
                {
                    var tileType = TileTypes(match.Groups[1].Length);
                    var bodyType = BodyType(match.Groups[2].Length);
                    var status = StatusOfFish(match.Groups[3].Value);

                    Console.WriteLine($"Fish {count}: {match}");
                    if (tileType == "None")
                    {
                        Console.WriteLine($"  Tail type: {tileType}");
                    }
                    else
                    {
                        Console.WriteLine($"  Tail type: {tileType} ({match.Groups[1].Length * 2} cm)");
                    }
                    Console.WriteLine($"  Body type: {bodyType} ({match.Groups[2].Length * 2} cm)");
                    Console.WriteLine($"  Status: {status}");

                    count++;

                }
            }
        }

        private static string StatusOfFish(string value)
        {
            if (value.Equals("'"))
            {
                return "Awake";
            }else if (value == "-")
            {
                return "Asleep";
            }else 
            {
                return "Dead";
            }    
            
        }

        private static string BodyType(int length)
        {
            if (length > 10)
            {
                return "Long";
            }
            else if (length > 5)
            {
                return "Medium";
            }
            else
            {
                return "Short";
            }
        }

        private static string TileTypes(int length)
        {
            if (length > 5)
            {
                return "Long";
            }
            else if (length > 1)
            {
                return "Medium";
            }
            else if(length == 1)
            {
                return "Short";
            }
            else
            {
                return "None";
            }
        }

      
    }
}
