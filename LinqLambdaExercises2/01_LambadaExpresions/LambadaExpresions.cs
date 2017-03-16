using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var result = new Dictionary<string, Dictionary<string, List<string>>>();
        var inputStr = Console.ReadLine();
        var firstKey = string.Empty;
        var innerKey = string.Empty;
        var innerValue = string.Empty;
        while (!inputStr.Equals("lambada"))
        {
            if (!inputStr.Equals("dance"))
            {
                var input = inputStr
                    .Split(new[] { '=', '>', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                firstKey = input[0];
                innerKey = input[1];
                innerValue = input[2];

                if (!result.ContainsKey(firstKey))
                {
                    result[firstKey] = new Dictionary<string, List<string>>();
                }
                if (!result[firstKey].ContainsKey(innerKey))
                {
                    result[firstKey][innerKey] = new List<string>();
                }
                result[firstKey][innerKey].Clear();
                result[firstKey][innerKey].Add(innerValue);
            }
            else
            {
                foreach (var key in result.Keys)
                {
                    foreach (var inKey in result[key].Keys)
                    {
                        result[key][inKey].Insert(0, inKey);
                    }
                }

            }
            inputStr = Console.ReadLine();
        }
        foreach (var key in result.Keys)
        {
            Console.Write("{0} => ", key);
            foreach (var inKey in result[key].Keys)
            {
                Console.WriteLine("{0}.{1}", inKey, string.Join(".", result[key][inKey]));
            }
        }
    }
}

