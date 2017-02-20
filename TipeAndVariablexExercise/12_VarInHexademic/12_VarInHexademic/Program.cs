using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_VarInHexademic
{
    class Program
    {
        static void Main(string[] args)
        {
            string numInHex = Console.ReadLine();
            int result = Convert.ToInt32(numInHex, 16);
            Console.WriteLine(result);
        }
    }
}
