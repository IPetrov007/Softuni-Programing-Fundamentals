using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSinceBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            byte years = byte.Parse(Console.ReadLine());
            ushort days = (ushort)(years * 365);
            int hours = days * 24;
            uint minutes = (uint)(hours * 60);

            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", years, days, hours, minutes);
        }
    }
}
