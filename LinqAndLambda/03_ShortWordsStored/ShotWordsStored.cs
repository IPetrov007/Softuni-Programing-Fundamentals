using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ShortWordsStored
{
    class ShotWordsStored
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var words = text
                .ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ', '.' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = words
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
