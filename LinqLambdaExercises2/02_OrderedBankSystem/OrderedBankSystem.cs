using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var result = new Dictionary<string, Dictionary<string, decimal>>();
        var inputStr = Console.ReadLine();
        var firstKey = string.Empty;
        var innerKey = string.Empty;
        decimal innerValue = 0;

        while (!inputStr.Equals("end"))
        {
            var input = inputStr
                .Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            firstKey = input[0];
            innerKey = input[1];
            innerValue = decimal.Parse(input[2]);
            if (!result.ContainsKey(firstKey))
            {
                result[firstKey] = new Dictionary<string, decimal>();
            }
            if (!result[firstKey].ContainsKey(innerKey))
            {
                result[firstKey].Add(innerKey, 0);
            }
            result[firstKey][innerKey] += innerValue;
            inputStr = Console.ReadLine();
        }
        result
            .OrderByDescending(bank => bank.Value.Sum(bal => bal.Value))
            .ThenByDescending(bank => bank.Value.Max(bal => bal.Value))
            .ToList()
            .ForEach(n => n.Value.OrderByDescending(x => x.Value)
            .ToList()
            .ForEach(account => Console.WriteLine("{0} -> {1} ({2})", account.Key, account.Value, n.Key)));


    }
}

