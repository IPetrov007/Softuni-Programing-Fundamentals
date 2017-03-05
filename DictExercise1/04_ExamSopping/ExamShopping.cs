using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExamSopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();


            string inputStr = Console.ReadLine();
            while (inputStr != "shopping time")
            {
                var input = inputStr.Split(' ').ToArray();
                string product = input[1];
                int quantity = int.Parse(input[2]);

                if (result.ContainsKey(product))
                {
                    result[product] += quantity;
                }
                else
                {
                    result.Add(product, quantity);
                }
                inputStr = Console.ReadLine();
            }

            inputStr = Console.ReadLine();

            while (inputStr != "exam time")
            {
                var input = inputStr.Split(' ').ToArray();
                string product = input[1];
                int quantity = int.Parse(input[2]);

                if (!result.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                    inputStr = Console.ReadLine();
                    continue;
                }
                if (result[product] <= 0)
                {
                    Console.WriteLine($"{product} out of stock");
                    inputStr = Console.ReadLine();
                    continue;
                }

                result[product] -= quantity;


                inputStr = Console.ReadLine();
            }

            foreach (var kvp in result.Keys)
            {
                if (result[kvp] > 0)
                    Console.WriteLine($"{kvp} -> {result[kvp]}");
            }
        }
    }
}

