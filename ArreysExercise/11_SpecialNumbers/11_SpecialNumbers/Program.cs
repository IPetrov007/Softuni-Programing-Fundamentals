using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //bool result;
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                
                while (i > 0)
                {
                    var lastDigit = i % 10;
                    sum += lastDigit;
                    i = i / 10;
                    Console.WriteLine(sum);
                }
                

            }
        }
    }
}
