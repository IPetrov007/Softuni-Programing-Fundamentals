using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfOrders = int.Parse(Console.ReadLine());
            var format = "d/M/yyyy";
            decimal totalPrice = 0;
            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                var orderDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

                var capsuleCount = long.Parse(Console.ReadLine());

                var year = orderDate.Year;
                var month = orderDate.Month;
                var dayInMonth = DateTime.DaysInMonth(year, month);

                var orderPrice = ((dayInMonth * capsuleCount) * pricePerCapsule);
                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }
            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
