using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            var nameAges = new Dictionary<string, int>();
            var nameSalarys = new Dictionary<string, double>();
            var namePositions = new Dictionary<string, string>();

            while (inputStr != "filter base")
            {
                var input = inputStr.Split(' ').ToArray();
                string name = input[0];

                var secondPartOfInputStr = 0;
                int.TryParse(input[2], out secondPartOfInputStr);
                var otherSecondPart = 0d;
                double.TryParse(input[2], out otherSecondPart);
                if (secondPartOfInputStr != 0)
                {
                    nameAges.Add(name, secondPartOfInputStr);
                }
                else if (otherSecondPart != 0.0)
                {
                    nameSalarys.Add(name, otherSecondPart);
                }
                else
                {
                    namePositions.Add(name, input[2]);
                }
                inputStr = Console.ReadLine();
            }
            string endCommand = Console.ReadLine();
            switch (endCommand)
            {
                case "Age":
                    foreach (var kvp in nameAges.Keys)
                    {
                        Console.WriteLine($"Name: {kvp}");
                        Console.WriteLine($"Age: {nameAges[kvp]}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Salary":
                    foreach (var kvp in nameSalarys.Keys)
                    {
                        Console.WriteLine($"Name: {kvp}");
                        Console.WriteLine($"Salary: {nameSalarys[kvp]:F2}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Position":
                    foreach (var kvp in namePositions.Keys)
                    {
                        Console.WriteLine($"Name: {kvp}");
                        Console.WriteLine($"Position: {namePositions[kvp]}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }
        }
    }
}
