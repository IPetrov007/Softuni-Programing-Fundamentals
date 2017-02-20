using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ArreySimmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();

            string[] newText = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                newText[i] = text[text.Length - (i + 1)];
            }

            bool isSymmetric = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != newText[i])
                {
                    isSymmetric = false;
                }
            }
            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
