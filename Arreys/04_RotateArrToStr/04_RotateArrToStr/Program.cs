using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_RotateArrToStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            string lastStr = arr[arr.Length - 1];

            for (int i = arr.Length; i > 1; i--)
            {
                arr[i - 1] = arr[i - 2];
            }
            arr[0] = lastStr;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
