using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_JSONParse
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }
    }
    class JSONParse
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            var input = Console.ReadLine()
                .Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Replace('"', ' ').Replace('[', ' ').Replace(']', ' ').Replace('{', ' ').Replace('}', ' ').Trim();
            }

            foreach (var str in input)
            {
                var student = str.Split(new[] { ',', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var studentName = student[1];
                var studentAge = int.Parse(student[3]);
                var studentGrades = student.Skip(5).Select(int.Parse).ToArray();

                Student newStudent = new Student();
                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;
                students.Add(newStudent);
            }

            foreach (var student in students)
            {
                if (student.Grades.Length == 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }

            }
        }
    }
}
