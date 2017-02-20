using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> frequency = new List<double>
            {
                261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88,
            };

            List<string> note = new List<string>
            {
                "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B",
            };
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                for (int k = 0; k < frequency.Count; k++)
                {
                    if (input[i] == frequency[k])
                    {
                        result.Add(note[k]);
                    }
                }
            }
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            foreach (var str in result)
            {
                if (str.Contains("#"))
                {
                    sharps.Add(str);
                }
                else
                {
                    naturals.Add(str);
                }
            }
            Console.WriteLine("Notes: {0}", string.Join(" ", result));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));
            double sumNaturals = 0;
            sumNaturals = SumElements(frequency, note, naturals, sumNaturals);
            double sumSharps = 0;
            sumSharps = SumElements(frequency, note, sharps, sumSharps);

            Console.WriteLine("Naturals sum: {0}", sumNaturals);
            Console.WriteLine("Sharps sum: {0}", sumSharps);
            
        }

        private static double SumElements(List<double> frequency, List<string> note, List<string> naturals, double sumNaturals)
        {
            for (int i = 0; i < naturals.Count; i++)
            {
                for (int j = 0; j < note.Count; j++)
                {
                    if (naturals[i] == note[j])
                    {
                        sumNaturals += frequency[j];
                    }
                }
            }

            return sumNaturals;
        }
    }
}
