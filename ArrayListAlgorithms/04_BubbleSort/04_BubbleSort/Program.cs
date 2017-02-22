using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var swappet = true;
            do
            {
                swappet = false;
                for (int i = 0; i < arr.Count -1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i);
                        swappet = true;                        
                    }
                    //else
                    //{
                    //    swappet = false;
                    //}
                }

            } while (swappet);
            Console.WriteLine(string.Join(" ",arr));
        }

        static void Swap(List<int> arr, int i)
        {
            var temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
        }
    }
}
