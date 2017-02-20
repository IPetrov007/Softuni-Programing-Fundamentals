using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_UnunionList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();



                for (int j = 0; j < integers.Count; j++)
                {
                    if (!(primalList.Contains(integers[j])))
                    {
                        primalList.Add(integers[j]);
                        integers.Remove(integers[j]);
                        j--;
                    }
                }
                for (int k = 0; k < integers.Count; k++)
                {
                    while (primalList.Contains(integers[k]))
                    {
                        primalList.Remove(integers[k]);
                    }
                    
                }
                //for (int k = 0; k < primalList.Count; k++)
                //{
                //    for (int h = 0; h < integers.Count; h++)
                //    {
                //        if (integers[h] == primalList[k])
                //        {
                //            primalList.Remove(integers[h]);
                //            k--;
                //        }
                //    }
                //}    
            }
            
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
