using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    public class Messages
    {
        public string Message { get; set; }

        public string Code { get; set; }
    }
    public class Broadcast
    {
        public string Message { get; set; }

        public string Frequency { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var privatMessagePattern = @"^([0-9]+) <-> ([a-zA-Z0-9]+)$";
            var broadcastMessagePattern = @"^([^0-9]+) <-> ([a-zA-Z0-9]+)$";

            var privatMessageRegx = new Regex(privatMessagePattern);
            var broadcastRegex = new Regex(broadcastMessagePattern);

            var messages = new List<Messages>();
            var broadcasts = new List<Broadcast>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                if (privatMessageRegx.IsMatch(input))
                {
                    var recipientsCode = privatMessageRegx
                        .Match(input)
                        .Groups[1]
                        .Value
                        .ToCharArray();
                    Array.Reverse(recipientsCode);
                    var recipCode = string.Join("", recipientsCode);

                    var message = privatMessageRegx
                        .Match(input)
                        .Groups[2]
                        .Value;

                    var newMessages = new Messages();
                    newMessages.Message = message;
                    newMessages.Code = recipCode;
                    messages.Add(newMessages);
                }
                if (broadcastRegex.IsMatch(input))
                {
                    var message = broadcastRegex
                        .Match(input)
                        .Groups[1]
                        .Value;

                    var frequency = broadcastRegex
                        .Match(input)
                        .Groups[2]
                        .Value
                        .ToCharArray();
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        var letter = frequency[i];
                        if (char.IsLower(letter))
                        {
                            frequency[i] = char.ToUpper(letter);
                        }
                        else
                        {
                            frequency[i] = char.ToLower(letter);
                        }
                    }
                    var reverFrequency = string.Join("", frequency);

                    var newBroadcast = new Broadcast();
                    newBroadcast.Message = message;
                    newBroadcast.Frequency = reverFrequency;
                    broadcasts.Add(newBroadcast);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine($"{item.Frequency} -> {item.Message}");
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in messages)
                {
                    Console.WriteLine($"{item.Code} -> {item.Message}");
                }
            }

        }
    }
}
