using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExactProductOfRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal product = 1;
            for (int i = 0; i < num; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                product *= numbers;
            }
            Console.WriteLine(product);
        }
    }
}
