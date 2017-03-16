using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CottageScraper
{
    class CottageSkraper
    {
        static void Main(string[] args)
        {
            var warehouse = new Dictionary<string, List<int>>();
            var inputStr = Console.ReadLine();
            while (inputStr != "chop chop")
            {
                var input = inputStr
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var key = input[0];
                var value = int.Parse(input[1]);
                if (!warehouse.ContainsKey(key))
                {
                    warehouse[key] = new List<int>();
                }
                warehouse[key].Add(value);
                inputStr = Console.ReadLine();
            }
            string typeOfTree = Console.ReadLine();
            int minLehghtOfTree = int.Parse(Console.ReadLine());
            var pricePerMeter = Math.Round(GetThePricePerMeter(warehouse), 2);

            Dictionary<string, List<int>> collectedTree = warehouse
                .Where(x => x.Key.Equals(typeOfTree))
                .ToDictionary(x => x.Key, x => x.Value);
            List<int> usedTree = new List<int>();
            foreach (var kvp in collectedTree)
            {
                foreach (int val in kvp.Value)
                {
                    if (val >= minLehghtOfTree)
                    {
                        usedTree.Add(val);
                    }
                }
            }

            var usedLogPrice = usedTree.Sum() * pricePerMeter;
            var unusedTreeSum = GetAllSum(warehouse) - usedTree.Sum();
            var unusedLogPrice = unusedTreeSum * pricePerMeter * 0.25;
            var cottageScraperSubtotal = unusedLogPrice + usedLogPrice;

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${cottageScraperSubtotal:F2}");
        }

        private static double GetAllSum(Dictionary<string, List<int>> warehouse)
        {
            var allSum = 0.0;
            foreach (var listValue in warehouse.Values)
            {
                allSum += listValue.Sum();
            }
            return allSum;
        }

        private static double GetThePricePerMeter(Dictionary<string, List<int>> warehouse)
        {
            var allSum = 0.0;
            var counts = 0;
            foreach (var listValue in warehouse.Values)
            {
                allSum += listValue.Sum();
                counts += listValue.Count;
            }
            return allSum / counts;
        }
    }
}
