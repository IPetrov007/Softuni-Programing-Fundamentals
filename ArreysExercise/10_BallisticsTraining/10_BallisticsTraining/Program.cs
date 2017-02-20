using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            string[] newCoordinates = Console.ReadLine().Split(' ').ToArray();

            double positionX = 0;
            double positionY = 0;

            for (int i = 0; i < newCoordinates.Length; i+=2)
            {
                if (newCoordinates[i].Equals("up"))
                {
                    positionY += Convert.ToInt32(newCoordinates[i + 1]);
                }
                else if (newCoordinates[i].Equals("down"))
                {
                    positionY -= Convert.ToInt32(newCoordinates[i + 1]);
                }
                else if (newCoordinates[i].Equals("left"))
                {
                    positionX -= Convert.ToInt32(newCoordinates[i + 1]);
                }
                else if (newCoordinates[i].Equals("right"))
                {
                    positionX += Convert.ToInt32(newCoordinates[i + 1]);
                }
            }
            Console.WriteLine($"firing at [{positionX}, {positionY}]");

            if (positionX == coordinates[0] && positionY == coordinates[1])
            {
                Console.WriteLine($"got 'em!");
            }
            else
            {
                Console.WriteLine($"better luck next time...");
            }
        }
    }
}
