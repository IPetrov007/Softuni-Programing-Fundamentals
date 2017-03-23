using System;
using System.Collections.Generic;


public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    //public Point(int X, int Y)
    //{
    //    this.X = X;
    //    this.Y = Y;
    //}
    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        var sideX = Math.Abs(firstPoint.X - secondPoint.X);
        var sideY = Math.Abs(firstPoint.Y - secondPoint.Y);

        return Math.Sqrt(Math.Pow((sideX), 2) + Math.Pow((sideY), 2));
    }
}

public class Box
{
    public Point UpperLeft { get; set; }
    public Point UpperRight { get; set; }
    public Point BottomLeft { get; set; }
    public Point BottomRight { get; set; }

    public static int CalculatePerimeter(int widht, int height)
    {
        return ((2 * widht) + (2 * height));
    }
    public static int CalculateArea(int widht, int height)
    {
        return (widht * height);
    }
}

namespace _05_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box>();
            var inputStr = Console.ReadLine();
            while (inputStr != "end")
            {
                var input = inputStr
                    .Split(new[] { ' ', ':', '|' },
                    StringSplitOptions.RemoveEmptyEntries);

                var newBox = new Box();
                newBox.UpperLeft = ReadPoint(int.Parse(input[0]), int.Parse(input[1]));
                newBox.UpperRight = ReadPoint(int.Parse(input[2]), int.Parse(input[3]));
                newBox.BottomLeft = ReadPoint(int.Parse(input[4]), int.Parse(input[5]));
                newBox.BottomRight = ReadPoint(int.Parse(input[6]), int.Parse(input[7]));
                boxes.Add(newBox);

                inputStr = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
                var height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);
                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter((int)width, (int)height)}");
                Console.WriteLine($"Area: {Box.CalculateArea((int)width, (int)height)}");
            }
        }

        private static Point ReadPoint(int x1, int x2)
        {
            var point = new Point
            {
                X = x1,
                Y = x2
            };
            return point;
        }
    }
}

