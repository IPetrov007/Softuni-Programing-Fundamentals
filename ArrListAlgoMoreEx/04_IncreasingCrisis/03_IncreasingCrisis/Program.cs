using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IncreasingCrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            int N = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < N; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (result.Count == 0)
                {
                    AddFisrtNumbers(result, numbers);
                    continue;
                }
                for (int k = 0; k < numbers.Length; k++)
                {
                    int h = result.Count - 1;
                    while (numbers[k] < result[h])
                    {
                        h--;
                    }
                    result.Insert(h + 1, numbers[k]);

                    if (k < numbers.Length - 1 && numbers[k] > numbers[k + 1])
                    {
                        int count = result.Count - (h + 2);
                        result.RemoveRange(h + 2, count);
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
        private static void AddFisrtNumbers(List<int> result, int[] numbers)
        {
            result.Add(numbers[0]);
            for (int k = 1; k < numbers.Length; k++)
            {
                
                    result.Add(numbers[k]);
                
            }
        }
    }
}
