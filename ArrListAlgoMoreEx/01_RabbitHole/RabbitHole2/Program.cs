using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> comands = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

            int currentIndex = 0;
            //bool hasSavedKennedy = false;
            bool lastBomb = false;

            while (energy > 0 )
            {
                string[] comandsParams = comands[currentIndex].Split('|');
                string currentComand = comandsParams[0];
                lastBomb = false;

                if (currentComand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    //hasSavedKennedy = true;
                    break;
                }

                int value = int.Parse(comandsParams[1]);

                switch (currentComand)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - value) % comands.Count;
                        energy -= value;
                        break;
                    case "Right":
                        currentIndex = (currentIndex + value) % comands.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        comands.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        lastBomb = true;
                        break;
                    
                }

                if (comands[comands.Count - 1] == "RabbitHole")
                {
                    comands.Add("Bomb|" + energy);
                }
                else
                {
                    comands.RemoveAt(comands.Count - 1);
                    comands.Add("Bomb|" + energy);
                }

                if (energy <= 0 && lastBomb)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
                else if (energy <= 0 && !lastBomb)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }
            }
        }
    }
}
