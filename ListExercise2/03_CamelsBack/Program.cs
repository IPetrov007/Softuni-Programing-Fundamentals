using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelSize = int.Parse(Console.ReadLine());
            int rounds = 0;

            while (!(buildings.Count == camelSize))
            {
                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
                rounds++;
            }
            if (rounds > 0)
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
            else
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
        }
    }
}
