using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_UserLogin
{
    class UserLogin
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            var passBook = new Dictionary<string, string>();

            while (inputStr != "login")
            {
                var input = inputStr.Split(' ').ToArray();
                var name = input[0];
                var pass = input[2];
                if (!passBook.ContainsKey(name))
                {
                    passBook.Add(name, pass);
                }
                else
                {
                    passBook[name] = pass;
                }
                inputStr = Console.ReadLine();
            }

            inputStr = Console.ReadLine();
            int unsuccessfulLogins = 0;
            while (inputStr != "end")
            {
                var input = inputStr.Split(' ').ToArray();
                var name = input[0];
                var pass = input[2];

                if (passBook.ContainsKey(name) && pass == passBook[name])
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                else if (!passBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name}: login failed");
                    unsuccessfulLogins++;
                }
                else
                {
                    Console.WriteLine($"{name}: login failed");
                    unsuccessfulLogins++;
                }
                inputStr = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {unsuccessfulLogins}");
        }
    }
}
