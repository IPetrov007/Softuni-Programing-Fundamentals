using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DictRef
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();

            var inputStr = Console.ReadLine();

            while (inputStr != "end")
            {
                var entry = new List<string>();

                entry = inputStr.Split('=').ToList();

                int parsedEntry;
                bool tryParseSecondStr = int.TryParse(entry[1].Trim(), out parsedEntry);
                if (parsedEntry != 0)
                {
                    if (!result.ContainsKey(entry[0].Trim()))
                    {
                        result.Add(entry[0].Trim(), parsedEntry);
                    }
                    else
                    {
                        result[entry[0].Trim()] = parsedEntry;
                    }
                }
                else
                {
                    if (result.ContainsKey(entry[1].Trim()))
                    {
                        int valueOfelement;
                        result.TryGetValue(entry[1].Trim(), out valueOfelement);
                        if (!result.ContainsKey(entry[0].Trim()))
                        {
                            result.Add(entry[0].Trim(), valueOfelement);
                        }
                        else
                        {
                            result[entry[0].Trim()] = valueOfelement;
                        }
                    }
                }

                

                inputStr = Console.ReadLine();
            }
            foreach (var kvp in result.Keys)
            {
                Console.WriteLine($"{kvp} === {result[kvp]}");
            }
        }
    }
}
