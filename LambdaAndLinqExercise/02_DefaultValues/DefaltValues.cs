using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DefaultValues
{
    class DefaltValues
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>();
            //var registryNull = new Dictionary<string, string>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                var input = command
                    .Split(new[] {' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var key = input[0];
                var value = input[1];

                dictionary[key] = value;

                //if (input[1].Equals("null"))
                //{
                //    registryNull[input[0]] = input[1];
                //}
                //else
                //{
                //    registry[input[0]] = input[1];
                //}
                

                command = Console.ReadLine();
            }
            var defaltValue = Console.ReadLine();

            var unchangedValues = dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            var changedValues = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaltValue);

            foreach (var item in unchangedValues)
            {
                Console.WriteLine("{0} <-> {1}", item.Key, item.Value);
            }

            foreach (var item in changedValues)
            {
                Console.WriteLine("{0} <-> {1}", item.Key, item.Value);
            }
        }
    }
}
