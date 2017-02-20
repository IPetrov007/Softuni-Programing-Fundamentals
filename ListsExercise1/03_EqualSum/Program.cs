using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> line2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < line1.Count; i++)
            {
                for (int j = 0; j < line2.Count; j++)
                {
                    if (line1[i] == line2[j])
                    {
                        line2.Remove(line2[j]);
                    }
                }
            }
            int sumLine1 = 0;
            int sumLine2 = 0;
            foreach (var num in line1)
            {
                sumLine1 += num;
            }
            foreach (var num in line2)
            {
                sumLine2 += num;
            }
            int sumDiff = (int)(Math.Abs(sumLine1 - sumLine2));
            if (sumLine1 == sumLine2)
            {
                Console.WriteLine($"Yes. Sum: {sumLine1}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {sumDiff}");
            }

        }
    }
}
