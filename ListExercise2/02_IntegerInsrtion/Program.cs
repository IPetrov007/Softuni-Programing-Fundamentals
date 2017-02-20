using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IntegerInsrtion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = string.Empty;
            while (!(input.Equals("end")))
            {
                input = Console.ReadLine();
                if (input.Equals("end"))
                {
                    break;
                }
                int num = int.Parse(input);
                int firstDigit = FirstDigit(num);
                list.Insert(firstDigit, num);
            }
            Console.WriteLine(string.Join(" ", list));
        }

        private static int FirstDigit(int num)
        {
            int firstDigit = num;
            while (firstDigit > 9)
            {
                firstDigit = num /= 10;
            }
            return firstDigit;
        }
    }
}
