using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputLine = input
                .Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

                var startIndex = -1;
                var count = -1;

                switch (inputLine[0])
                {
                    case "reverse":
                        startIndex = int.Parse(inputLine[2]);
                        count = int.Parse(inputLine[4]);
                        if (startIndex < 0 || startIndex > inputNumbers.Count)
                        {
                            PrintEnd();
                            continue;
                        }

                        if (count < 0 || (startIndex + count) > inputNumbers.Count)
                        {
                            PrintEnd();
                            continue;
                        }

                        inputNumbers.Reverse(startIndex, count);
                        break;
                    case "sort":
                        startIndex = int.Parse(inputLine[2]);
                        count = int.Parse(inputLine[4]);
                        if (startIndex < 0 || startIndex > inputNumbers.Count)
                        {
                            PrintEnd();
                            continue;
                        }

                        if (count < 0 || (startIndex + count) > inputNumbers.Count)
                        {
                            PrintEnd();
                            continue;
                        }
                        inputNumbers.Sort(startIndex, count, null);
                        break;

                    case "rollLeft":
                        count = int.Parse(inputLine[1]);
                        if (count < 0)
                        {
                            PrintEnd();
                            continue;
                        }
                        result = inputNumbers;
                        for (int i = 0; i < count % inputNumbers.Count; i++)
                        {
                            var tempChar = result[0];
                            result.RemoveAt(0);
                            result.Add(tempChar);
                        }
                        inputNumbers = result;
                        break;
                    case "rollRight":
                        count = int.Parse(inputLine[1]);
                        if (count < 0)
                        {
                            PrintEnd();
                            continue;
                        }
                        result = inputNumbers;
                        for (int i = 0; i < count % inputNumbers.Count; i++)
                        {
                            var tempChar = result[result.Count - 1];
                            result.RemoveAt(result.Count - 1);
                            result.Insert(0, tempChar);
                        }
                        inputNumbers = result;
                        break;

                }
            }
                Console.WriteLine("[" + string.Join(", ", inputNumbers) + "]");
        }

        private static void PrintEnd()
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }
}

