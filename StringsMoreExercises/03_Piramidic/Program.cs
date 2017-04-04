using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Piramidic
{
    public class Piramidic
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                stringArray[i] = input;
            }
            var maxCounter = int.MinValue;
            var maxChar = '0';

            var counter = 1;

            for (int i = 0; i < stringArray.Length; i++)
            {
                var currentWord = stringArray[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    var currentChar = currentWord[j];

                    var nextRowCharLenght = 3;


                    for (int k = i + 1; k < stringArray.Length; k++)
                    {
                        var nextRowChar = new string(currentChar, nextRowCharLenght);

                        if (stringArray[k].Contains(nextRowChar))
                        {
                            counter++;
                            nextRowCharLenght += 2;
                        }
                        else
                        {
                            nextRowCharLenght = 3;
                            break;
                        }
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxChar = currentChar;
                    }
                    counter = 1;
                }
            }
            var widht = 1;
            for (int i = 1; i <= maxCounter; i++)
            {
                Console.WriteLine(new string(maxChar, widht));
                widht += 2;
            }
        }
    }
}
