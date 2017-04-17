using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_RoliTheCoder
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Participants { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var events = new Dictionary<int, Event>();
            var result = new List<Event>();


            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }

                var request = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var eventId = 0;
                if (!int.TryParse(request[0], out eventId))
                {
                    continue;
                }

                var eventName = request[1];
                if (request.Length > 1 && eventName.StartsWith("#"))
                {
                    eventName = eventName.Trim('#');
                }

                var participants = new List<string>();
                if (request.Length > 2)
                {
                    participants = request.Skip(2).ToList();
                    if (!request.Skip(2).ToArray().All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }

                if (events.ContainsKey(eventId))
                {
                    if (events[eventId].Name == eventName)
                    {
                        events[eventId].Participants.AddRange(participants);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    var newEvent = new Event();
                    newEvent.Id = eventId;
                    newEvent.Name = eventName;
                    newEvent.Participants = participants;
                    result.Add(newEvent);

                    events.Add(eventId, newEvent);
                }
            }

            var sortedResult = result
                    .OrderByDescending(x => x.Participants.Count)
                    .ThenBy(x => x.Name)
                    .ToList();

            foreach (var ev in sortedResult)
            {
                var distinctPart = ev.Participants.Distinct().ToList();
                Console.WriteLine($"{ev.Name} - {distinctPart.Count}");
                foreach (var participant in distinctPart.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}

