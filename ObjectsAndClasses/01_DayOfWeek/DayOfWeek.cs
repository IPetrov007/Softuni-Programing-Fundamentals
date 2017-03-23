using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var dateString = Console.ReadLine();
            var dateResult = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dateResult.DayOfWeek);
        }
    }
}
