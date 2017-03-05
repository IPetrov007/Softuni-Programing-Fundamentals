using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string comand = null;
            int energy = 0;
            string[] comandsAndEnerges = new string[2];
            comandsAndEnerges = input[0].Split('|');
            comand = comandsAndEnerges[0];
            energy = int.Parse(comandsAndEnerges[1]);
        }
    }
}
