using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ASCIIString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int letter = int.Parse(Console.ReadLine());
                
                result.Append((char)letter).Append("");
            }
            Console.WriteLine(result);
        }
    }
}
