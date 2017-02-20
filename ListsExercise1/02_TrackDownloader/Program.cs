using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blackList = Console.ReadLine().Split(' ').ToList();
            List<string> fileNames = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();
            
            bool endOfWhile = fileNames.Contains("end");
            while (!(endOfWhile))
            {
                bool stay = true;

                for (int i = 0; i < fileNames.Count; i++)
                {
                    foreach (var item in blackList)
                    {
                        if (fileNames[i].Contains(item))
                        {
                            stay = false;
                            break;
                        }
                    }
                }

                if (stay)
                {
                    string newFileNames = string.Join(" ", fileNames);
                    result.Add(newFileNames);
                }

                fileNames = Console.ReadLine().Split(' ').ToList();
                endOfWhile = fileNames.Contains("end");

            }
            result.Sort();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
