using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var haveValidSimbols = "([$@#^])\\1{5,}";

            var tickets = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();
            var leftPart = "";
            var rightPatr = "";

            Regex regex = new Regex(haveValidSimbols);

            foreach (var ticket in tickets)
            {

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                leftPart = ticket.Substring(0, ticket.Length / 2);
                rightPatr = ticket.Substring(ticket.Length / 2);

                var leftMatch = regex.Match(leftPart);
                var rightMatch = regex.Match(rightPatr);


                if (leftMatch.Success && rightMatch.Success)// && leftMatch == rightMatch)
                {
                    var counter = Math.Min(leftMatch.Length, rightMatch.Length);

                    var symbol = ' ';
                    if (leftMatch.Value[0] != rightMatch.Value[0])
                    {

                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                        continue;
                    }
                    else
                    {
                        symbol = leftMatch.Value[0];
                    }



                    if (counter == 10)
                    {
                        Console.WriteLine($"ticket \"{ ticket}\" - {counter}{symbol} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ ticket}\" - {counter}{symbol}");
                    }
                    counter = 0;
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");

                }


            }
        }
    }
}