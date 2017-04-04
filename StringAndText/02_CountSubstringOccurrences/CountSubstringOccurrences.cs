using System;


namespace _02_CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().ToLower();

            var word = Console.ReadLine().ToLower();

            var counter = 0;

            var index = inputLine.IndexOf(word);

            while (index != -1)
            {
                counter++;
                index = inputLine.IndexOf(word, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
