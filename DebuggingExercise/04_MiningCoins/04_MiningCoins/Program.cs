using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MiningCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = "";
            float totalValue = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digit1 = number / 100;
                int digit2 = (number % 100) / 10;
                int digit3 = number % 10;
                
                int asciicode = 0;

                if (i % 2 == 0)
                {
                    asciicode = ((digit1 * 10) + digit3) + digit2;
                }
                else
                {
                    asciicode = ((digit1 * 10) + digit3) - digit2; 
                }
                
                if ((asciicode >= 65 && asciicode <= 90) || (asciicode >= 97 && asciicode <= 122))
                {
                    decrypted += (char)asciicode;
                }
                totalValue += (digit1 + digit2 + digit3) / (float)n;
            }

            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:f7}", totalValue);
        }
    }
}

