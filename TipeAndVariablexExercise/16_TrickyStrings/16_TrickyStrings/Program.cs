using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < lines; i++)
            {
                string part = Console.ReadLine();
                result.Append(part);
                if (i < lines - 1)
                {
                    result.Append(delimeter);
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(result);
        }
    }
}
