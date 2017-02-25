using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AverageCharDelime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            double sumOfChars = 0;
            int numbersOfChars = 0;

            for (int i = 0; i < input.Count; i++)
            {
                numbersOfChars += input[i].Count();
                double sumOfElement = 0;
                foreach (var element in input[i])
                {
                    sumOfElement += (double)element;
                }
                sumOfChars += sumOfElement;
            }
            double averageSum = sumOfChars / numbersOfChars;
            if (averageSum >= 97 && averageSum <= 122)
            {
                averageSum -= 32;
            }

            char delimeter = (char)(averageSum);
            Console.WriteLine(string.Join(delimeter.ToString(), input));
        }
    }
}
