using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                   PrintUpPartOfTriangle(n);
            }
            
            PrintDownPart(n);
            
        }

        static void PrintUpPartOfTriangle(int end, int start = 1)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintDownPart(int end, int start = 1)
        {
            for (int i = end - 1; i < start; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
