using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newFile = File.ReadAllLines("Input.txt");

            for (int i = 1; i < newFile.Length; i+= 2)
            {
                File.AppendAllText("../../result.txt", newFile[i] + Environment.NewLine);
            }
        }
    }
}
