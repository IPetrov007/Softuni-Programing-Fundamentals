using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercise
{
    public string Topic { get; set; }
    public string CourseName { get; set; }
    public string JudgeContestLink { get; set; }
    public List<string> Problems { get; set; }
}
namespace _01_Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            List<Exercise> result = new List<Exercise>();

            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("go go go"))
            {
                var input = inputLine
                    .Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                Exercise ex1 = new Exercise();
                result.Add(ex1);
                ex1.Topic = input[0];
                ex1.CourseName = input[1];
                ex1.JudgeContestLink = input[2];
                ex1.Problems = new List<string>();
                for (int i = 3; i < input.Length; i++)
                {
                    ex1.Problems.Add(input[i]);
                }
                inputLine = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");
                int count = 1;
                foreach (var str in item.Problems)
                {
                    Console.WriteLine($"{count}. {str}");
                    count++;
                }
            }
        }
    }
}
