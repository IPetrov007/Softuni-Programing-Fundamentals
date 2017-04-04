using System;
using System.Text;

namespace _01_ReverseStrings
{
    public class ReverseString
    {
        public static void Main()
        {
            var inputStr = Console.ReadLine();
            var reverseStr = new StringBuilder();

            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                reverseStr.Append(inputStr[i]);
            }
            Console.WriteLine(reverseStr.ToString());
        }
    }
}
