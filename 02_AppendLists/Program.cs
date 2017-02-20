using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<string>();


            string input = Console.ReadLine();
    
            string[] tokens = input.Split('|');

            for (int i = 0; i < tokens.Length; i++)
            {
                string abc = tokens[i];
                tokens[i] = abc.Split(' ');

            }
        }
    }
}
