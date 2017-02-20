using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StrEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 0; i < num; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                result += Encrypt(letter);
            }
            Console.WriteLine(result);
        }
        static string Encrypt(char letter)
        {
            int ascii = (int)letter;
            int lastDigit = ascii / 10;
            int middleDigit = ascii / 100;
            int firstDigit = ascii / 1000;
            string appendStr = (char)firstDigit + (char)middleDigit;
            return
            int firstDigit = ascii / 1000;
        }
    }
}
