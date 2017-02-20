using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            double[] numbers = new double[(arr.Length / 2) + 1];
            string[] text = new string[arr.Length / 2];

            int j = 0;

            for (int i = 0; i < arr.Length; i += 2)
            {

                numbers[j] = Convert.ToInt32(arr[i]);
                j++;

            }

            j = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                text[j] = arr[i];
                j++;
            }

            double altitude = numbers[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals("up"))
                {
                    altitude += (numbers[i + 1]);
                }
                else if(text[i].Equals("down"))
                {
                    altitude -= (numbers[i + 1]);
                }
                if (altitude <= 0)
                {
                    
                    break;
                }
            }
            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            
           
        }
    }
}
