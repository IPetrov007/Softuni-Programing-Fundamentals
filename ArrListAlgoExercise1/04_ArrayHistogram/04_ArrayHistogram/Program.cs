using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            List<string> words = new List<string>();
            List<int> counts = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!words.Contains(arr[i]))
                {
                    words.Add(arr[i]);
                    counts.Add(1);
                }
                else
                {
                    for (int k = 0; k < words.Count; k++)
                    {
                        if (arr[i] == words[k])
                        {
                            counts[k]++;
                        }
                    }
                }
            }
               bool unsorted = true;
                while (unsorted)
                {
                    unsorted = false;
                    for (int i = 0; i < counts.Count - 1; i++)
                    {
                    if (counts[i] < counts[i + 1])
                    {
                        int temp = counts[i];
                        counts[i] = counts[i + 1];
                        counts[i + 1] = temp;

                        string tempStr = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempStr;

                        unsorted = true;
                    }
                    
                    }
                }
            

            for (int i = 0; i < words.Count; i++)
            {
                double percentsge = (counts[i] * 100.00)/arr.Length;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", words[i], counts[i], percentsge);
            }
        }
    }
}
