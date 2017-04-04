using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            var secntence = Console.ReadLine();
            var delimiter = Console.ReadLine();
            var splitedSentence = secntence
                .Split(new string[] { delimiter }, StringSplitOptions.None)
                .ToArray();
            Console.WriteLine("[" + string.Join(", ", splitedSentence) + "]");
        }
    }
}
