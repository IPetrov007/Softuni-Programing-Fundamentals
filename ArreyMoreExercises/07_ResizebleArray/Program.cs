using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] arrA = new int?[4];

            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "push":
                        arrA = AddNumberToEnd(arrA, input[1]);
                        break;

                    case "pop":
                        arrA = RemoveLastNumber(arrA);
                        break;

                    case "removeAt":
                        arrA = RemoveNumberAtIndex(arrA, input[1]);
                        break;

                    case "clear":
                        ClearAllContents(arrA);
                        break;
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            bool isArrAEmpty = IsArrAEmpty(arrA);
            if (isArrAEmpty)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(string.Join(" ",arrA));
            }
          
        }

        static bool IsArrAEmpty(int?[] arrA)
        {
            bool yes = true;
            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] != null)
                {
                    yes = false;
                    break;
                }
            }
            return yes;
        }

        static int?[]  AddNumberToEnd(int?[] arrA, string input)
        {
            int num = Convert.ToInt32(input);
            bool isArrayFull = IsArrayFull(arrA);


            if (isArrayFull)
            {
                int?[] arrB = new int?[arrA.Length * 2];
                Array.Copy(arrA, 0, arrB, 0, arrA.Length);
                //arrB[arrA.Length] = num;
                arrA = arrB;
                
            }
            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] == null)
                {
                    arrA[i] = num;
                    break;
                }
            }
            return arrA;

        }

        static bool IsArrayFull(int?[] arrA)
        {
            bool result = true;
            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] == null)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        static int?[] RemoveLastNumber(int?[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] == null)
                {
                    arrA[i - 1] = null;
                    break;
                }
                else
                {
                    arrA[arrA.Length - 1] = null;
                }
            }
            return arrA;
        }

        static int?[] RemoveNumberAtIndex(int?[] arrA, string input)
        {
            int?[] arrB = new int?[arrA.Length];
            int num = Convert.ToInt32(input);
            for (int i = 0; i < arrA.Length - 1; i++)
            {
                if (i >= num)
                {
                    arrB[i] = arrA[i + 1];
                }
                else
                {
                    arrB[i] = arrA[i];
                }
            }
            return arrB;
        }

        static void ClearAllContents(int?[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = null;
            }
        }
    }
}


