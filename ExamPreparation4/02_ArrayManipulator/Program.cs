using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NewArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                var comandLine = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var comand = comandLine[0];

                switch (comand)
                {
                    case "exchange":
                        var index = int.Parse(comandLine[1]);
                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        var leftPart = arr.Take(index + 1).ToArray();
                        var rightPart = arr.Skip(index + 1).ToArray();
                        arr = rightPart.Concat(leftPart).ToArray();
                        break;

                    case "max":
                    case "min":
                        var maxOrMin = comand;
                        var evenOrOdd = comandLine[1];
                        GetIndexOfElement(arr, maxOrMin, evenOrOdd);
                        break;
                    case "first":
                    case "last":
                        var firstOrLast = comand;
                        var count = int.Parse(comandLine[1]);
                        evenOrOdd = comandLine[2];
                        ReturnCounElements(arr, firstOrLast, count, evenOrOdd);
                        break;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));

        }

        private static void ReturnCounElements(int[] arr, string firstOrLast, int count, string evenOrOdd)
        {
            if (count < 0 || count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var result = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = arr.Where(s => s % 2 == result).ToArray();
            var lastOrFirstArr = firstOrLast == "first" ? evenOrOddElements.Take(count).ToArray() : evenOrOddElements.Reverse().Take(count).Reverse().ToArray();
            Console.WriteLine("[{0}]", string.Join(", ", lastOrFirstArr));
            return;
        }

        private static void GetIndexOfElement(int[] arr, string maxOrMin, string evenOrOdd)
        {
            var result = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = arr.Where(s => s % 2 == result).ToArray();
            if (evenOrOddElements.Length == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            var maxOrMinElement = maxOrMin == "max" ? evenOrOddElements.Max() : evenOrOddElements.Min();
            var lastIndexOfElement = Array.LastIndexOf(arr, maxOrMinElement);
            Console.WriteLine(lastIndexOfElement);
            return;
        }
    }
}
