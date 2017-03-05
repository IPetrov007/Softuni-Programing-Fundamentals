using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_JapanRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cilinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<string> powerAndDirections = Console.ReadLine().Split(' ').ToList();

            int bulletIndex = 0;
            bulletIndex = NewMethod(cilinder, bulletIndex);
            for (int i = 0; i < powerAndDirections.Count; i++)
            {
                string[] player = new string[2];
                player = powerAndDirections[i].Split(',');
                string playerDirection = player[1];
                int playerPower = int.Parse(player[0]);
                              
                
                if (playerDirection == "Right")
                {
                    bulletIndex = (bulletIndex + playerPower) % cilinder.Length;
                }
                else if (playerDirection == "Left")
                {
                    bulletIndex = Math.Abs((playerPower - bulletIndex)) % cilinder.Length;
                }
                if (bulletIndex == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    bulletIndex = 7;
                    break;
                }
                else
                {
                    bulletIndex++;
                }

            }
            if (bulletIndex != 7)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }

        private static int NewMethod(int[] cilinder, int bulletIndex)
        {
            for (int k = 0; k < cilinder.Length; k++)
            {
                if (cilinder[k] == 1)
                {
                    bulletIndex = k;
                    break;
                }
            }

            return bulletIndex;
        }
    }
}
