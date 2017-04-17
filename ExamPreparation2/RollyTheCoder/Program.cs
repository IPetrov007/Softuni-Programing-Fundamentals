using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollyTheCoder
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public SortedSet<string> Participants { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var existingIds = new Dictionary<int, string>();
            var events = new List<Event>();
            
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }

                var inputStr = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var id = -1;
                if (!int.TryParse(inputStr[0], out id))
                {
                    continue;
                }

                var eventName = inputStr[1];
                if (!eventName.StartsWith("#"))
                {
                    continue;
                }
                else
                {
                    eventName = eventName.TrimStart('#');
                }
                var participants = inputStr
                    .Skip(2)
                    .ToList();
                if (!participants.All(x => x.StartsWith("@")))
                {
                    continue;
                }

                if (existingIds.ContainsKey(id))
                {
                    if (existingIds[id] != eventName)
                    {
                        continue;
                    }
                    else
                    {
                        foreach (var ev in events)
                        {
                            if (ev.Id == id)
                            {
                                foreach (var part in participants)
                                {
                                    ev.Participants.Add(part);
                                }
                                
                            }
                        }
                    }
                }
                else
                {
                    existingIds.Add(id, eventName);

                    var hashSetParticipans = new SortedSet<string>();
                    var newEvent = new Event();
                    newEvent.Id = id;
                    newEvent.Name = eventName;
                    foreach (var part in participants)
                    {
                        hashSetParticipans.Add(part);
                    }
                    newEvent.Participants = hashSetParticipans;
                    events.Add(newEvent);
                }
            }
            var result = events
                .OrderByDescending(p => p.Participants.Count)
                //.ThenBy(n => n.Participants)
                .ToList();
 
            foreach (var ev in result)
            {
                Console.WriteLine($"{ev.Name} - {ev.Participants.Count}");

                foreach (var item in ev.Participants)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
