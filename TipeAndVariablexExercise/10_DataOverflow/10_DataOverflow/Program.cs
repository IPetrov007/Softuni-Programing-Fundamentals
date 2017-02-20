using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());

            ulong maxNum = Math.Max(a, b);
            ulong minNum = Math.Min(a, b);

            string maxValio = String.Empty;
            string minValio = String.Empty;


            if (byte.MinValue <= maxNum && maxNum <= byte.MaxValue)
            {
                maxValio = "byte";
            }
            else if (ushort.MinValue <= maxNum && maxNum <= ushort.MaxValue)
            {
                maxValio = "ushort";
            }

            else if (uint.MinValue <= maxNum && maxNum <= uint.MaxValue)
            {
                maxValio = "uint";
            }
            else if (ulong.MinValue <= maxNum && maxNum <= ulong.MaxValue)
            {
                maxValio = "ulong";
            }



            ulong tipeMaxValue = 0;

            if (byte.MinValue <= minNum && minNum <= byte.MaxValue)
            {
                minValio = "byte";
                tipeMaxValue = byte.MaxValue;
            }

            else if (ushort.MinValue <= minNum && minNum <= ushort.MaxValue)
            {
                minValio = "ushort";
                tipeMaxValue = ushort.MaxValue;
            }
            else if (uint.MinValue <= minNum && minNum <= uint.MaxValue)
            {
                minValio = "uint";
                tipeMaxValue = uint.MaxValue;
            }
            else if (ulong.MinValue <= minNum && minNum <= ulong.MaxValue)
            {
                minValio = "ulong";
                tipeMaxValue = ulong.MaxValue;
            }

            Console.WriteLine("bigger type: " + maxValio);
            Console.WriteLine("smaller type: " + minValio);

            int overflows = (int)Math.Round((double)maxNum / tipeMaxValue);
            Console.WriteLine($"{maxNum} can overflow {minValio} {overflows} times");


        }
    }
}