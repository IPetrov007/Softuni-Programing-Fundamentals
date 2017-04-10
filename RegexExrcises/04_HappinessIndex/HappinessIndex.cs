using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main()
        {
            var HappyPattern = @":\)|:D|;\)|:\*|:]|;]|:]|:}|;}|\(:|\*:|c:|\[:|\[;";
            var SadPattern = @":\(|D:|;\(|:\[|;\[|:\{|;\{|\):|:c|\]:|\];";

            Regex HappyRegex = new Regex(HappyPattern);
            Regex SadRegex = new Regex(SadPattern);

            var input = Console.ReadLine();
            var happyCount = HappyRegex.Matches(input).Count;
            var sadCount = SadRegex.Matches(input).Count;
            var HappinessIndex = happyCount / (double)sadCount;
            var picture = HappinessPicture(HappinessIndex);

            Console.WriteLine($"Happiness index: {HappinessIndex:F2} {picture}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }

        private static string HappinessPicture(double happinessIndex)
        {
            if (happinessIndex >= 2)
            {
                return ":D";
            }
            else if (happinessIndex > 1)
            {
                return ":)";
            }
            else if (happinessIndex == 1)
            {
                return ":|";
            }
            else
            {
                return ":(";
            }
            {

            }
        }
    }
}
