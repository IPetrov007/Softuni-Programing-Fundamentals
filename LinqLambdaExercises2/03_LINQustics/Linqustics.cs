using System;
using System.Collections.Generic;
using System.Linq;


class LINQuistics
{
    static void Main(string[] args)
    {
        var result = new Dictionary<string, List<string>>();
        var inputLine = Console.ReadLine();
        var collection = String.Empty;

        while (!inputLine.Equals("exit"))
        {
            var input = inputLine
                .Split(new[] { '.', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            collection = input[0];
            int count = 0;

            if (input.Count() > 1)
            {
                AddToCollection(result, collection, input);
            }
            else if (result.ContainsKey(collection))
            {
                PrintCollectionsElements(result, collection);
            }
            else if (int.TryParse(input[0], out count) && result.Count > 0)
            {
                PrintNMethods(result, count);
            }

            inputLine = Console.ReadLine();
        }


        var finalInput = Console.ReadLine().Split(' ').ToArray();
        var method = finalInput[0];

        Dictionary<string, List<string>> finalResult = FinalResultOrder(result, method);

        var selection = finalInput[1];

        if (selection.Equals("all"))
        {
            PrintAll(finalResult);
        }
        else if (selection.Equals("collection"))
        {
            PrintOnlyCollections(finalResult);
        }
    }

    private static void AddToCollection(Dictionary<string, List<string>> result, string collection, string[] input)
    {
        if (!result.ContainsKey(collection))
        {
            result[collection] = new List<string>();
        }
        for (int i = 1; i < input.Length; i++)
        {
            if (!result[collection].Contains(input[i]))
            {
                result[collection].Add(input[i]);
            }
        }
    }

    private static Dictionary<string, List<string>> FinalResultOrder(Dictionary<string, List<string>> result, string method)
    {
        return result
                        .Where(y => y.Value.Contains(method))
                        .OrderByDescending(y => y.Value.Count)
                        .ThenByDescending(y => y.Value.Min(z => z.Length))
                        .ToDictionary(x => x.Key, x => x.Value);
    }

    private static void PrintOnlyCollections(Dictionary<string, List<string>> finalResult)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var key in finalResult.Keys)
        {
            Console.WriteLine(key);
        }
        Console.ResetColor();
    }

    private static void PrintAll(Dictionary<string, List<string>> finalResult)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var key in finalResult)
        {
            Console.WriteLine(key.Key);

            foreach (var item in finalResult[key.Key].OrderByDescending(x => x.Count()))
            {
                Console.WriteLine("* {0}", item);
            }
        }
        Console.ResetColor();
    }

    private static void PrintNMethods(Dictionary<string, List<string>> result, int count)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        var printNMethods = result.Values
                                .OrderByDescending(x => x.Count).First()
                                .OrderBy(x => x.Length)
                                .Take(count)
                                .ToList();

        foreach (var item in printNMethods)
        {
            Console.WriteLine("* {0}", item);
        }
        Console.ResetColor();
    }

    private static void PrintCollectionsElements(Dictionary<string, List<string>> result, string collection)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        var resultForPrinting = result[collection]
                                .OrderByDescending(x => x.Length)
                                .ThenByDescending(x => x.Distinct().Count())
                                .ToList();
        foreach (var values in resultForPrinting)
        {
            Console.WriteLine("* {0}", values);
        }
        Console.ResetColor();
    }
}

