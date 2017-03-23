using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine().Split(' ').ToArray();
            var rnd = new Random();

            var rndNum = rnd.Next(0, inputStr.Length);

            for (int i = 0; i < inputStr.Length - 1; i++)
            {
                var temp = inputStr[i];
                inputStr[i] = inputStr[rndNum];
                inputStr[rndNum] = temp;
            }
            foreach (var str in inputStr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
