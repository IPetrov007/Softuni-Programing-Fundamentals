using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_MultiDictionaries
{
    class MultiDictionaries
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var inputStr = Console.ReadLine()
                    .Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                var name = inputStr[0];
                var grade = double.Parse(inputStr[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var people in grades.Keys)
            {
                Console.Write($"{people} -> ");

                foreach (var grape in grades[people])
                {
                    Console.Write($"{grape:f2} ");
                }
                Console.WriteLine($"(avg: {grades[people].Average():f2})");
            }
        }
    }
}
