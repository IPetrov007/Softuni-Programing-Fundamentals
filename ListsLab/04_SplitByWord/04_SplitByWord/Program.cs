using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SplitByWord
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }; ;
            List<string> input = Console.ReadLine().Split(separator).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {

                if (InputLowerCase(input[i]))
                {
                    lowerCase.Add(input[i]);
                }
                else if (InputUpperCase(input[i]))
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }

                
            }

            Console.WriteLine("Lower-case:" + (string.Join(", ", lowerCase)));
            Console.WriteLine("Mixed-case:" + (string.Join(", ", mixedCase)));
            Console.WriteLine("Upper-case:" + (string.Join(", ", upperCase)));
            
        }

        static bool InputLowerCase(string inputString)
        {
            bool result = true;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!(inputString[i] >= 'a' && inputString[i] <= 'z'))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        static bool InputUpperCase(string inputString)
        {
            bool result = true;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!(inputString[i] >= 'A' && inputString[i] <= 'Z'))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
