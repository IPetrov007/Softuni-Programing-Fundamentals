using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }
                int num = int.Parse(Console.ReadLine());
                var digits = "";
                var text = "";
                var number = -1;
                if (int.TryParse(input[0].ToString(), out number))
                {
                    
                    foreach (var character in input)
                    {
                        if (int.TryParse(character.ToString(), out number))
                        {
                            digits += character;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                { 
                    continue;
                }
                
                
                var secondPart = input.Remove(0, digits.Length);
                foreach (var character in secondPart)
                {
                    var isCapitalLetter = character > 64 && character < 91;
                    var isSmallLetter = character > 96 && character < 123;
                    if (isCapitalLetter || isSmallLetter)
                    {
                        text += character;
                    }
                    else
                    {
                        break;
                    }
                }
                if (text.Length != num)
                {
                    break;
                }
                var lastPart = secondPart.Remove(0, text.Length);
                var isLetter = false;
                foreach (var character in lastPart)
                {
                    var isCapitalLetter = character > 64 && character < 91;
                    var isSmallLetter = character > 96 && character < 123;
                    if (isCapitalLetter || isSmallLetter)
                    {
                        isLetter = true;
                        break;
                    }
                }
                if (isLetter)
                {
                    continue;
                }
                if ((digits.Length + text.Length + lastPart.Length) != input.Length)
                {
                    break;
                }
                var lastDigits = "";
                foreach (var character in lastPart)
                {
                    number = -1;
                    if (int.TryParse(character.ToString(), out number))
                    {
                        lastDigits += character;
                    }
                }
                var allDigits = digits + lastDigits;
                var verificationCode = "";

                foreach (var index in allDigits)
                {
                    var digit = int.Parse(index.ToString());
                    if (digit < text.Length)
                    {
                        verificationCode += text[digit];
                    }
                    else
                    {
                        verificationCode += " ";
                    }
                }
                Console.WriteLine($"{text} == {verificationCode}");
            }

        }
    }
}
