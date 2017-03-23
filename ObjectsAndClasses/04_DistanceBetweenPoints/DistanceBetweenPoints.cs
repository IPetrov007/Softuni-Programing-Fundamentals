using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point one = new Point();
            {
                X = inputStr[0];
                Y = inputStr[1];
            }
            inputStr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point two = new Point();
            var X = inputStr[0];
            var Y = inputStr[1];


        }
        
    }
}
