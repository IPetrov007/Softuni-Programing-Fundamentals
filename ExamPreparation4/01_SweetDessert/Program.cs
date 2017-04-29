using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            int portions = guests / 6;
            if (guests % 6 > 0)
            {
                portions++;
            }
            decimal pricePerPortion = (2 * bananasPrice) + (4 * eggsPrice) + (berriesPrice / 5);
            decimal neededMoney = portions * pricePerPortion;
            if (neededMoney <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                var lackOfMoney = neededMoney - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {lackOfMoney:F2}lv more.");
            }
        }
    }
}
