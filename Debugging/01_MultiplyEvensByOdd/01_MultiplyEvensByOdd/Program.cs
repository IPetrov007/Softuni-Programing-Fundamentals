using System;

namespace _01_MultiplyEvensByOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            Console.WriteLine(GetMultipleOfEvensAndOdds(num));

        }
        static int GetMultipleOfEvensAndOdds(int num)
        {
            int sumEvents = GetSumOfEvenDigit(num);
            int sumOdds = GetSumOfOddDigit(num);

            return sumEvents * sumOdds;
        }
        static int GetSumOfEvenDigit(int num)
        {
            int sumOfEvenDidgit = 0;
            while (num > 0)
            {
                int LastDigit = num % 10;
                if (LastDigit % 2 == 0)
                {
                    sumOfEvenDidgit += LastDigit;
                }
                num /= 10;
            }
            return sumOfEvenDidgit;
        }

        static int GetSumOfOddDigit(int num)
        {
            int sumOfOddDidgit = 0;
            while (num > 0)
            {
                int LastDigit = num % 10;
                if (!(LastDigit % 2 == 0))
                {
                    sumOfOddDidgit += LastDigit;
                }
                num /= 10;
            }
            return sumOfOddDidgit;
        }

    }
}
