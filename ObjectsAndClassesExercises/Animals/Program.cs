using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Legs { get; set; }
    public static string ProduceSound()
    {
        return "I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
    }
}
public class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int IQ { get; set; }
    public static string ProduceSound()
    {
        return "I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
    }
}
public class Snake
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Cruelty { get; set; }
    public static string ProduceSound()
    {
        return "I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.";
    }
}

namespace _03_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dogs = new Dictionary<string, Dog>();
            var Cats = new Dictionary<string, Cat>();
            var Snakes = new Dictionary<string, Snake>();

            var inputStr = Console.ReadLine();

            while (!inputStr.Equals("I'm your Huckleberry"))
            {
                var input = inputStr.Split(' ').ToArray();

                if (input.Length > 2)
                {
                    var @class = input[0];
                    switch (@class)
                    {
                        case "Dog":
                            Dogs[input[1]] = new Dog();
                            Dog dog = new Dog();
                            dog.Name = input[1];
                            dog.Age = int.Parse(input[2]);
                            dog.Legs = int.Parse(input[3]);
                            Dogs[dog.Name] = dog; ;
                            break;
                        case "Cat":
                            Cats[input[1]] = new Cat();
                            Cat cat = new Cat();
                            cat.Name = input[1];
                            cat.Age = int.Parse(input[2]);
                            cat.IQ = int.Parse(input[3]);
                            Cats[cat.Name] = cat;
                            break;
                        case "Snake":
                            Snakes[input[1]] = new Snake();
                            Snake snake = new Snake();
                            snake.Name = input[1];
                            snake.Age = int.Parse(input[2]);
                            snake.Cruelty = int.Parse(input[3]);
                            Snakes[snake.Name] = snake; ;
                            break;
                    }
                }
                else
                {
                    var name = input[1];
                    if (Dogs.ContainsKey(name))
                    {
                        Console.WriteLine($"{Dog.ProduceSound()}");
                    }
                    else if (Cats.ContainsKey(name))
                    {
                        Console.WriteLine($"{Cat.ProduceSound()}");
                    }
                    else if (Snakes.ContainsKey(name))
                    {
                        Console.WriteLine($"{Snake.ProduceSound()}");
                    }
                }

                inputStr = Console.ReadLine();
            }

            PrintDogs(Dogs);
            PrintCats(Cats);
            PrintSnakes(Snakes);
        }

        private static void PrintSnakes(Dictionary<string, Snake> snakes)
        {
            foreach (var kvp in snakes)
            {
                Console.Write($"Snake: {kvp.Key}, ");
                Console.WriteLine($"Age: {kvp.Value.Age}, Cruelty: {kvp.Value.Cruelty}");
            }
        }

        private static void PrintCats(Dictionary<string, Cat> cats)
        {
            foreach (var kvp in cats)
            {
                Console.Write($"Cat: {kvp.Key}, ");
                Console.WriteLine($"Age: {kvp.Value.Age}, IQ: {kvp.Value.IQ}");
            }
        }

        private static void PrintDogs(Dictionary<string, Dog> Dogs)
        {
            foreach (var kvp in Dogs)
            {
                Console.Write($"Dog: {kvp.Key}, ");
                Console.WriteLine($"Age: {kvp.Value.Age}, Number Of Legs: {kvp.Value.Legs}");
            }
        }

    }
}
