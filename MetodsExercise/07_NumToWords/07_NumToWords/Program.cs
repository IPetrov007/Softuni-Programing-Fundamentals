using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NumToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string result = string.Empty;

                int num = int.Parse(Console.ReadLine());

                if (num > 999)
                {
                    Console.WriteLine("too large");
                    continue;
        }
                if (num < -999)
                {
                    Console.WriteLine("too small");
                    continue;
                }
                
                if (num < 0)
                {
                    result += "minus ";
                }
                if (num > -100 && num < 100)
                {
                    continue;
                }
                num = Math.Abs(num);

                string hundreds = (num / 100).ToString();
                result += FirstAndLastDigits(hundreds) + "-hundred";

                int last2Digit = (num % 100);

                if (last2Digit == 0)
                {
                    Console.WriteLine(result);
                    continue ;
                }
                else if (last2Digit < 10)
                {
                    result += " and " + FirstAndLastDigits(last2Digit.ToString());
                }
                else if (last2Digit >= 20)
                {
                    string lastDigit = (last2Digit % 10).ToString();
                    result += " and " + TeenNumAfter20(last2Digit) + FirstAndLastDigits(lastDigit);
                }
                else if (last2Digit >= 10)
                {
                    result += " and " + TeenNumTo20(last2Digit);
                }
                Console.WriteLine(result);
            }
        }
        static string NumSize(int num)
        {
            string result = string.Empty;
            if (num > 999)
            {
                result = "too large";
            }
            if (num < -999)
            {
                result = "too small";
            }
            return result;
        }
        static string TeenNumAfter20(int last2Digit)
        {
            string result = string.Empty;

            int firstDigit = last2Digit / 10;

            switch (firstDigit)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "fourty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
            }
            if (last2Digit % 10 > 0)
            {
                result += " ";
            }
            return result;
        }
        static string TeenNumTo20(int last2Digit)
        {
            string result = string.Empty;
            if (last2Digit < 20)
            {
                switch (last2Digit.ToString())
                {
                    case "10":
                        result = "ten";
                        break;
                    case "11":
                        result = "eleven";
                        break;
                    case "12":
                        result = "twelve";
                        break;
                    case "13":
                        result = "thirteen";
                        break;
                    case "14":
                        result = "fourteen";
                        break;
                    case "15":
                        result = "fifteen";
                        break;
                    case "16":
                        result = "sixteen";
                        break;
                    case "17":
                        result = "seventeen";
                        break;
                    case "18":
                        result = "eighteen";
                        break;
                    case "19":
                        result = "nineteen";
                        break;
                }
            }
            return result;
        }
        static string FirstAndLastDigits(string hundreds)
        {
            string result = string.Empty;
            switch (hundreds)
            {
                case "1":
                    result += "one";
                    break;
                case "2":
                    result += "two";
                    break;
                case "3":
                    result += "three";
                    break;
                case "4":
                    result += "four";
                    break;
                case "5":
                    result += "five";
                    break;
                case "6":
                    result += "six";
                    break;
                case "7":
                    result += "seven";
                    break;
                case "8":
                    result += "eight";
                    break;
                case "9":
                    result += "nine";
                    break;
             }
            return result;
        }
    }
}
