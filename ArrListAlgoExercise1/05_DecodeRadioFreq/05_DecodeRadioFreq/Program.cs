using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DecodeRadioFreq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] frequence = new string[2];
                frequence = input[i].Split('.');
                int leftPart = int.Parse(frequence[0]);
                int rightPart = int.Parse(frequence[1]);
                char leftChar = (char)leftPart;
                char RightChar = (char)rightPart;
                if (leftPart != 0)
                {
                    result.Insert(i, leftChar);
                }
                if (rightPart != 0)
                {
                    result.Insert(result.Count - i, RightChar);
                }
            }
            
            Console.WriteLine(string.Join("", result));
            
        }
    }
}
