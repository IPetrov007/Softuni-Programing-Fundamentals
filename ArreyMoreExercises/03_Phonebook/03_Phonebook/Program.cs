using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string input = string.Empty;

            while (!(input.Equals("done")))
            {
                input = Console.ReadLine();

                for (int i = 0; i < names.Length; i++)
                    {
                    if (names[i] == input)
                        {
                        Console.WriteLine($"{names[i]} -> {numbers[i]}");
                        break;
                        }
                    }
                
            }
        }
    }
}
