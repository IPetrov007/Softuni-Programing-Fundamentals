using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_JSON_stringify
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }
    class JSONStringify
    {
        static void Main(string[] args)
        {
            List<Student> listOfSudents = new List<Student>();
            var inputLine = Console.ReadLine();
            while (inputLine != "stringify")
            {
                var input = inputLine
                    .Split(new[] { ' ', ':', '-', '>', ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var studentName = input[0];
                var studentAge = int.Parse(input[1]);
                var studentGrades = input
                    .Skip(2)
                    .Select(int.Parse)
                    .ToArray();

                Student newStudent = new Student();
                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;
                listOfSudents.Add(newStudent);

                inputLine = Console.ReadLine();
            }

            Console.Write("[");
            for (int i = 0; i < listOfSudents.Count; i++)
            {
                Console.Write("{");
                Console.Write($"name:\"{listOfSudents[i].Name}\",age:{listOfSudents[i].Age},grades:[{string.Join(", ", listOfSudents[i].Grades)}]");
                Console.Write("}");
                if (i < listOfSudents.Count - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
        }
    }
}
