using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var fields = new int[fieldSize];

            var indexesOfLadybigs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (var index in indexesOfLadybigs)
            {
                if (index >= 0 && index < fields.Length)
                {
                    fields[index] = 1;
                }
            }

            while (true)
            {
                var comand = Console.ReadLine();
                if (comand == "end")
                {
                    break;
                }

                var input = comand
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var ladybugIndex = int.Parse(input[0]);
                var direction = input[1];
                var flyLenght = int.Parse(input[2]);

                if (ladybugIndex < 0 || ladybugIndex >= fields.Length || fields[ladybugIndex] == 0)
                {
                    continue;
                }

                fields[ladybugIndex] = 0;

                var landingIndex = ladybugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        landingIndex += flyLenght;
                    }
                    else
                    {
                        landingIndex -= flyLenght;
                    }

                    if (landingIndex < 0 || landingIndex >= fields.Length)
                    {
                        break;
                    }

                    if (fields[landingIndex] == 0)
                    {
                        fields[landingIndex] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", fields));
        }
    }
}
