using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FloatOfInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var intNum = (int)(num);
            if (num > intNum)
            {
                Console.WriteLine(Math.Round(num));
            }
            else
            {
                Console.WriteLine(intNum);
            }
        }
    }
}
