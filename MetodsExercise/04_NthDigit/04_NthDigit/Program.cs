using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            

            int result = FindNthDigit(number, index);

            Console.WriteLine(result);
        }
        static int FindNthDigit(int number, int index)
        {
            int lastDigit = 0;

            for (int i = 0; i < index; i++)
            {
                lastDigit = number % 10;

                number = number / 10;
                   
            }
            return lastDigit;
        }
    }
}
