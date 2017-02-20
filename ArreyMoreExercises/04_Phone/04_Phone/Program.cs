using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string stop = string.Empty;
            string number = string.Empty;
            string name = string.Empty;
            int inputIndexInArrey = 0;
            int sumOfDigits = 0;
            int differenceOfDigits = 0;
            string duration = string.Empty;

            while (!(stop == "done"))
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                stop = input[0];
                if (stop == "done")
                {
                    break;
                }
                inputIndexInArrey = InputIndexInArrey(input[1], names, numbers);
                number = TheNumberIs(input[1], numbers);
                name = TheNameIs(input[1], names);
                sumOfDigits = SumOfDigits(numbers[inputIndexInArrey]);
                duration = GetDuration(sumOfDigits);
                differenceOfDigits = GetDifOfDigit(numbers[inputIndexInArrey]);

                switch (input[0])
                {
                    case "call":
                        if (input[1].Equals(number))
                        {
                            Console.WriteLine($"calling {names[inputIndexInArrey]}...");
                        }
                        else
                        {
                            Console.WriteLine($"calling {numbers[inputIndexInArrey]}...");
                        }
                        if (sumOfDigits % 2 != 0)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            Console.WriteLine($"call ended. duration: {duration}");
                        }

                        break;
                    case "message":
                        if (input[1].Equals(number))
                        {
                            Console.WriteLine($"sending sms to {names[inputIndexInArrey]}...");
                        }
                        else
                        {
                            Console.WriteLine($"sending sms to {numbers[inputIndexInArrey]}...");
                        }
                        if (differenceOfDigits %2 != 0)
                        {
                            Console.WriteLine("busy");
                        }
                        else
                        {
                            Console.WriteLine("meet me there");
                        }

                        break;
                }

            }
        }

        private static int GetDifOfDigit(string numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (item >= '0' && item <= '9')
                {
                    int num = item - '0';
                    sum -= num;
                }
            }
            return sum;
        }

        static string GetDuration(int sumOfDigits)
        {

            int mm = sumOfDigits / 60;
            int ss = sumOfDigits % 60;
            string duration = Convert.ToString($"{mm:00}:{ss:00}");
            return duration;
        }

        static int SumOfDigits(string numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (item >= '0' && item <= '9')
                {
                    int num = item - '0';
                    sum += num;
                }
           }
            return sum;
        }

        static int InputIndexInArrey(string input1, string[] names, string[] numbers)
        {
            int result = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (input1 == names[i])
                {
                    result = i;
                    break;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (input1 == numbers[i])
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        static string TheNameIs(string input1, string[] names)
        {
            string name = string.Empty;

            foreach (var item in names)
            {
                if (input1.Equals(item))
                {
                    name = item;
                }
            }
            return name;
        }

        static string TheNumberIs(string input1, string[] numbers)
        {
            string number = string.Empty;

            foreach (var item in numbers)
            {
                if (input1.Equals(item))
                {
                    number = item;
                }
            }
            return number;
        }
    }
}
