using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = GetMin(a, b);

            int c = int.Parse(Console.ReadLine());

            int newResult = GetMin(result, c);

            //Console.WriteLine(result);
            Console.WriteLine(newResult);
        }

        static int GetMin(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
