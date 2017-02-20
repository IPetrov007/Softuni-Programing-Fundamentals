using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IntToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string converted = IntegerToBase(number, toBase);

            Console.WriteLine(converted);
        }

        static string IntegerToBase(int number, int toBase)
        {
            var result = String.Empty;
            while (number > 0)
            {
                
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;

            }
            return result;
            
        }
    }
}
