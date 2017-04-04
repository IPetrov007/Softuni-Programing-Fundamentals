using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CapitalizeWords
{
    public class CapitalizeWord
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "end")
            {
                var words = input
                    .Split(new[] { ' ', ',', '.', ':', ';', '[', ']', '{', '}', '"', '\\', '(', ')', '-', '=', '>', '<', '~', '|', '`', '?', '!', '/', '*', '%', '$', '#', '@', '^', '&' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToLower())
                    .ToArray();

                var result = new List<string>();

                for (int i = 0; i < words.Length; i++)
                {
                    if (!words[i].Equals(string.Empty))
                    {
                        words[i] = UppercaseFirst(words[i]);
                        result.Add(words[i]);
                    }

                }
                Console.WriteLine(string.Join(", ", result));
                input = Console.ReadLine();
            }
        }
        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
