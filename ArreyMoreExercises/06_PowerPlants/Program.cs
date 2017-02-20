using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = plants.Length;
            //bool end = IsNotEnd(plants);
            int seasons = 0;
            int days = 1;
            int count = 0;

            while (!IsTheEnd(plants))
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                       
                        if (IsTheEnd(plants))
                        {
                            break;
                        }
                        if (plants[i] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (i == count)
                            {
                                plants[i]++;
                            }
                        }
                        plants[i]--;
                    }
                    
                    if (IsTheEnd(plants))
                    {
                        break;
                    }
                    count++;
                    days++;
                }
                count = 0;
                seasons++;
                for (int i = 0; i < plants.Length; i++)
                {
                    if (plants[i] != 0)
                    {
                        plants[i]++;
                    }
                }
                
            }
            if (seasons > 1)
            {
                Console.WriteLine($"survived {days} days ({seasons - 1} seasons)");
            }
            else
            {
                Console.WriteLine($"survived {days} days ({seasons - 1} season)");
            }
        }

        static bool IsTheEnd(int[] plants)
        {
            bool result = true;
            foreach (var item in plants)
            {
                if (item != 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
