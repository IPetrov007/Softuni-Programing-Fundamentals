using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxPersonPerCourse = 4 + 8 + 12;

            int courses = (int)Math.Ceiling(((double)n / maxPersonPerCourse));

            Console.WriteLine(courses);
        }
    }
}
