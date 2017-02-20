using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FromTeraToBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());
            int kilobytes = (1024 * 1024 * 8);
            double bits = terabytes * kilobytes * 1024 * 1024;

            Console.WriteLine(bits);
        }
    }
}
