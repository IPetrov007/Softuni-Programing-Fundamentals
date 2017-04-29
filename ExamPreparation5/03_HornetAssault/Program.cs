using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                var hornetsPower = hornets.Sum();
                var bee = beehives[i];
                if (bee == hornetsPower)
                {
                    beehives.RemoveAt(i);
                    hornets.RemoveAt(0);
                    i--;
                }
                else if (bee > hornetsPower)
                {
                    beehives[i] = bee - hornetsPower;
                    hornets.RemoveAt(0);
                }
                else
                {
                    beehives.RemoveAt(i);
                    i--;
                }
            }
            if (beehives.Any())
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
