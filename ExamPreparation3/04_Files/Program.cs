using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Files
{
    public class File
    {
        public string Name { get; set; }

        public string Root { get; set; }

        public long Size { get; set; }

        public string Extention { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var files = new List<File>();

            for (int i = 0; i < N; i++)
            {
                var inputStr = Console.ReadLine()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var sizeOfFile = long.Parse(inputStr[1]);
                var fileInfo = inputStr[0]
                    .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var root = fileInfo[0];
                var fileNameAndExtention = fileInfo[fileInfo.Length - 1].Split('.').ToArray();

                var fileName = "";
                var fileExtention = "";
                if (fileNameAndExtention.Length == 2)
                {
                    fileName = fileNameAndExtention[0];
                    fileExtention = fileNameAndExtention[1];
                }
                else
                {
                    continue;
                }


                if (files.Any(f => f.Name == fileName && f.Root == root && f.Extention == fileExtention))
                {
                    foreach (var file in files)
                    {
                        if (file.Name == fileName && file.Extention == fileExtention && file.Root == root)
                        {
                            file.Size = sizeOfFile;
                        }
                    }
                    continue;
                }
                else
                {
                    var newFile = new File();
                    newFile.Name = fileName;
                    newFile.Root = root;
                    newFile.Size = sizeOfFile;
                    newFile.Extention = fileExtention;
                    files.Add(newFile);
                }
            }
            var endCommand = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var extention = endCommand[0];
            var currentRoot = endCommand[2];

            var result = files.OrderByDescending(f => f.Size).ThenBy(f => f.Name).ToList();

            if (result.Any(f => f.Extention == extention && f.Root == currentRoot))
            {
                foreach (var file in result.Where(f => f.Extention == extention && f.Root == currentRoot))
                {
                    Console.WriteLine($"{file.Name}.{file.Extention} - {file.Size} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}

