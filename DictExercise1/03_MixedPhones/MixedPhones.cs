using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var result = new SortedDictionary<string, long>();
            string inputStr = Console.ReadLine();

            while (inputStr != "Over")
            {
                var input = inputStr
                    .Split(
                    new[] { ' ', ':' },
                    StringSplitOptions.RemoveEmptyEntries);



                long phoneNumber;
                
                if (long.TryParse(input[0], out phoneNumber))
                {
                    result[input[1]] = phoneNumber;
                }
                else if (long.TryParse(input[1], out phoneNumber))
                {
                    result[input[0]] = phoneNumber;
                }
                inputStr = Console.ReadLine();
            }
            foreach (var kvp in result.Keys)
            {
                Console.WriteLine($"{kvp} -> {result[kvp]}");
                
            }
            
        }
    }
}
