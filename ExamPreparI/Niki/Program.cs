using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niki
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 300; i < 999; i++)
            {
                int a = i - 297;
                string a1 = a.ToString();

                var b1 = i.ToString();
                char[] result = b1.ToCharArray();
                Array.Reverse(result);
                var newResult = string.Join("", result);


                if (a1.Equals(newResult))
                {
                    count++;
                }

            }
            Console.WriteLine("ABC - 297 = CBA");
            Console.WriteLine("How much is the three digits numbers?");
            Console.WriteLine($"The answer is: {count}");
            Console.WriteLine();
        }
    }
}
