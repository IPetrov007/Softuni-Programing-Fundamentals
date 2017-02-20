using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> line2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minLenghtLine1= MinLenghtLine(line1);
            int minLenghtLine2 = MinLenghtLine(line2);
            int minLenght = Math.Min(minLenghtLine1, minLenghtLine2);

            line1 = RemoveLongerElemenys(line1, minLenght);
            line2 = RemoveLongerElemenys(line2, minLenght);
                        
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Max(line1.Count, line2.Count); i++)
            {
                try
                {
                    result.Add(line2[i]);
                }
                catch (Exception){}
                try
                {
                    result.Add(line1[i]);
                }
                catch (Exception){}
                
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> RemoveLongerElemenys(List<int> line, int minLenght)
        {
            int lenght1 = line.Count;
            List<int> result = new List<int>();
            for (int i = 0; i < lenght1; i++)
            {
                string output = Math.Abs(line[i]).ToString();
                if (output.Length == minLenght)
                {
                    result.Add(line[i]);
                }
            }
            return result;
        }

        static int MinLenghtLine(List<int> line1)
        {

            int minCount = int.MaxValue;
            int count = 0;
            for (int i = 0; i < line1.Count; i++)
            {
                int element = Math.Abs(line1[i]);
                while (element > 0)
                {
                    element /= 10;
                    count++;
                }
                if (count <= minCount)
                {
                    minCount = count;
                    count = 0;
                }
            }
            return minCount;
        }
    }
}
