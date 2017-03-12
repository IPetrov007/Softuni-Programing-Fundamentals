using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RegisteredUser
{
    class RegisteredUser
    {
        static void Main(string[] args)
        {
            var registry = new Dictionary<string, DateTime>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                var input = command
                    .Split(new[]{' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var username = input[0];

                string format = "dd/MM/yyyy";
                DateTime date = DateTime.ParseExact(input[1], format, CultureInfo.InvariantCulture);

                registry[username] = date;

                command = Console.ReadLine();
            }

            var result = registry
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);


            foreach (var kpv in result.Keys)
            {
                Console.WriteLine(kpv);
            }
        }
    }
}
