using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_NetherRealms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            var result = new SortedDictionary<string, Demon>();

            //var healthPattern = @"[^0-9\+\-\*\/\.]";
            //Regex healMatch = new Regex(healthPattern);
            var damagePattern = @"-?\d+\.?\d*";
            Regex damageMatch = new Regex(damagePattern);



            foreach (var demonsName in names)
            {

                int health = 0;
                //var demonsHealth = healMatch.Matches(demonsName);
                var demonsHealth = demonsName
                .Where(s =>
                !char.IsDigit(s) &&
                s != '+' &&
                s != '-' &&
                s != '*' &&
                s != '/' &&
                s != '.');
                foreach (var item in demonsHealth)
                {
                    //var character = Convert.ToChar(item);
                    health += item;
                }

                double damage = 0;
                var demonsDamage = damageMatch.Matches(demonsName);
                foreach (Match item in demonsDamage)
                {
                    var character = double.Parse(item.Value);
                    damage += character;
                }
                foreach (var symbol in demonsName)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                var newDemon = new Demon();
                newDemon.Damage = damage;
                newDemon.Health = health;
                newDemon.Name = demonsName;
                result.Add(demonsName, newDemon);

            }

            foreach (var animal in result)
            {
                var currentDemon = animal.Value;
                Console.WriteLine($"{animal.Key} - {currentDemon.Health} health, {currentDemon.Damage:f2} damage");
            }
        }
    }
}
