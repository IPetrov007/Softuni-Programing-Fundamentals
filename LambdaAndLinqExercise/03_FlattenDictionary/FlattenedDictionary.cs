using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FlattenDictionary
{
    class FlattenedDictionary
    {
        static void Main(string[] args)
        {
            var registry = new Dictionary<string, Dictionary<string, string>>();
            var inputStr = Console.ReadLine();
            while (inputStr != "end")
            {
                var input = inputStr
                    .Split(' ')
                    .ToArray();

                if (!input[0].Equals("flatten"))
                {
                    var key = input[0];
                    var innerKey = input[1];
                    var innerValue = input[2];

                    if (!registry.Keys.Contains(key))
                    {
                        registry[key] = new Dictionary<string, string>();
                    }
                    registry[key][innerKey] = innerValue;
                }
                else
                {
                    registry[input[1]] = registry[input[1]]
                            .ToDictionary(x => x.Key + x.Value, x => "flattened" );
                }
                inputStr = Console.ReadLine();
            }

            var dictOrdered = registry
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in dictOrdered)
            {
                Console.WriteLine("{0}", entry.Key);

                var innerDict = entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedValues = entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;
                foreach (var innetItem in innerDict)
                {
                    Console.WriteLine("{0}. {1} - {2}", count, innetItem.Key, innetItem.Value);
                    count++;
                }
                foreach (var innerItem in flattenedValues)
                {
                    Console.WriteLine("{0}. {1}", count, innerItem.Key);
                    count++;
                }

            }


            

        }
    }
}
