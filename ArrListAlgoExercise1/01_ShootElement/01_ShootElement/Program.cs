using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ShootElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string command = string.Empty;
            int lastRemoved = 0;

            while (command != "stop")
            {
                command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }
                else if (command != "bang")
                {
                    int num = int.Parse(command);
                    list.Insert(0, num);
                }
                else if (command == "bang" && list.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                    break;
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        double sum = list.Sum();
                        int count = list.Count();
                        double averageNum = sum / count;
                        if (list[i] <= averageNum)
                        {
                            lastRemoved = list[i];
                            list.Remove(list[i]);
                            Console.WriteLine($"shot {lastRemoved}");
                            for (int k = 0; k < list.Count; k++)
                            {
                                list[k]--;
                            }
                            break;
                        }
                    }
                }
             }

            
            if (list.Count > 0)
            {
                var survivor = string.Join(" ", list);
                Console.WriteLine($"survivors: {survivor}");
            }
            else if (list.Count == 0 && command == "stop")
            {
                Console.WriteLine($"you shot them all. last one was {lastRemoved}");
            }
            

            
        }
    }
}
