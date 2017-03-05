using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            int allPower = int.Parse(Console.ReadLine());

            string comand = string.Empty;
            int energy = 0;
            string startValue = input[0];

            do
            {
                if (startValue == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                else
                {
                    string[] comandsAndEnerges = new string[2];
                    comandsAndEnerges = startValue.Split('|');
                    comand = comandsAndEnerges[0].ToString();
                    energy = int.Parse(comandsAndEnerges[1]);

                    int currentIndex = 0;
                    switch (comand)
                    {
                        case "Right":
                            currentIndex = (energy % input.Count) + currentIndex;
                            allPower -= energy;
                            startValue = input[currentIndex + 1];
                            break;
                        case "Left":
                            currentIndex = Math.Abs(energy % input.Count) - currentIndex;
                            allPower -= energy;
                            startValue = input[currentIndex];
                            break;
                        case "Bomb":
                            input.RemoveAt(currentIndex);
                            allPower -= energy;
                            startValue = input[0];
                            break;

                    }
                    if (allPower < 0)
                    {
                        break;
                    }
                    else if (input[input.Count - 1] == "RubbitHole")
                    {
                        string newElement = "Bomb|" + allPower.ToString();
                        input.Add(newElement);
                    }
                    else
                    {
                        input.RemoveAt(input.Count - 1);
                        string newElement = "Bomb|" + allPower.ToString();
                        input.Add(newElement);
                    }

                }
            } while (allPower > 0);

            if (allPower <= 0 && comand != "Bomb" && comand != "RabbitHole")
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
            else if (allPower <= 0 && comand == "Bomb" && comand != "RabbitHole")
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }

        }
    }
}
