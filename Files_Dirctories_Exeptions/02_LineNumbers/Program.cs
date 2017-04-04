using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllLines("input.txt");

            var count = 1;
            foreach (var line in file)
            {
                File.AppendAllText("../../result.txt",$"{count}. " + line + Environment.NewLine);
                count++;
            }
        }
    }
}
