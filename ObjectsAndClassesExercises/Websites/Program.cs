using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Website
{
    public string Host { get; set; }
    public string Domain { get; set; }
    public List<String> Queries { get; set; }
}

namespace _04_Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            var Websites = new List<Website>();

            var inputStr = Console.ReadLine();

            while (!inputStr.Equals("end"))
            {
                var input = inputStr
                    .Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var web = new Website();
                Websites.Add(web);
                web.Host = input[0];
                web.Domain = input[1];
                web.Queries = new List<string>();
                for (int i = 2; i < input.Length; i++)
                {
                    web.Queries.Add("[" + input[i] + "]");
                }
                inputStr = Console.ReadLine();
            }
            foreach (var web in Websites)
            {
                if (web.Queries.Count > 0)
                {
                    Console.Write($"https://www.{web.Host}.{web.Domain}/query?=");
                    //web.Queries = web.Queries.Select(x => x = "[" + x + "]");

                    Console.Write(string.Join("&", web.Queries));

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"https://www.{web.Host}.{web.Domain}");
                }
            }
        }
    }
}
