using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "collapse")
            {
                var states = input;
                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    states = states.Replace(fiction, "").Trim();

                    fiction = fiction.Remove(0, 1);
                    if (fiction.Length > 0)
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                }

                if (states == "")
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(states);
                }


                input = Console.ReadLine();
            }


        }
    }
}
