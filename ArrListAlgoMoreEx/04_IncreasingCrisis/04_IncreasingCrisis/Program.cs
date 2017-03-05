using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IncreasingCrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            int N = int.Parse(Console.ReadLine());
            bool isTheLast;
            for (int i = 0; i < N; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (result.Count == 0)
                {
                    AddFisrtNumbers(result, numbers);
                }
                else
                {
                    for (int j = result.Count - 1; j >= 0; j--)
                    {
                        int firstNumber = numbers[0];

                        if (firstNumber < result[0])
                        {
                            result.Insert(0, firstNumber);
                            InsertBeforeElements(result, numbers, j);
                            break;

                        }

                        bool isInTheMiddle = true;
                        try
                        {
                            isInTheMiddle = firstNumber >= result[j - 1] && firstNumber < result[j];
                        }
                        catch (Exception)
                        {

                            continue;
                        } 
                        
                            if (isInTheMiddle)
                        {
                            isTheLast = false;
                            result.Insert(j, firstNumber);
                            InsertElements(result, numbers, j, isTheLast);
                            break;
                        }
                        else if (firstNumber >= result[result.Count - 1])
                        {
                            isTheLast = true;
                            result.Insert(result.Count, numbers[0]);
                            InsertElements(result, numbers, j, isTheLast);
                            break;
                        }

                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void InsertBeforeElements(List<int> result, int[] numbers, int j)
        {
            for (int l = 1; l < numbers.Length; l++)
            {
                if (numbers[l] >= numbers[l - 1])
                {
                    result.Insert(l, numbers[l]);
                }
                else
                {
                    int elementsToRemove = result.Count - (l);
                    result.RemoveRange(l, elementsToRemove);
                    break;
                }
            }
        }

        private static void AddFisrtNumbers(List<int> result, int[] numbers)
        {
            result.Add(numbers[0]);
            for (int k = 1; k < numbers.Length; k++)
            {
                if (IsTheNextIsBigger(numbers[k - 1], numbers[k]))
                {
                    result.Add(numbers[k]);
                }
                else
                {
                    break;
                }
            }
        }

        private static void InsertElements(List<int> result, int[] numbers, int j, bool isTheLast)
        {
            for (int l = 1; l < numbers.Length; l++)
            {
                if (numbers[l] >= numbers[l - 1])
                {
                    result.Insert(j + 1 + l, numbers[l]);
                }
                else if (isTheLast)
                {
                    break;
                }
                else
                {
                    int elementsToRemove = result.Count - (j + l);
                    result.RemoveRange(j + l, elementsToRemove);
                    break;
                }
            }
        }

        private static bool IsTheNextIsBigger(int a, int b)
        {
            if (a > b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
