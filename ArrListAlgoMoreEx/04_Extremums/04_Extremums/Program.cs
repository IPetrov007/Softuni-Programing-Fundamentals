using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string word = Console.ReadLine();

            List<int> result = new List<int>();

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int sum = 0;

            if (word == "Min")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    int element = input[i];
                    string strElement = element.ToString();

                    int count = 0;
                    while (count <= strElement.Length)
                    {
                        if (element < minValue)
                        {
                            minValue = element;
                        }
                        strElement = ShiftString(strElement);
                        element = int.Parse(strElement);
                        count++;
                    }
                    result.Add(minValue);
                    sum += minValue;
                    minValue = int.MaxValue;
                }
            }
            if (word == "Max")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    int element = input[i];
                    string strElement = element.ToString();

                    int count = 0;
                    while (count <= strElement.Length)
                    {
                        if (element > maxValue)
                        {
                            maxValue = element;
                        }
                        strElement = ShiftString(strElement);
                        element = int.Parse(strElement);
                        count++;
                    }
                    result.Add(maxValue);
                    sum += maxValue;
                    maxValue = int.MinValue;
                }
            }
            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(sum);


        }
        static string ShiftString(string str)
        {
            string firstCahr = str.Substring(0, 1);
            return str.Substring(1) + firstCahr;
        }
    }
}
