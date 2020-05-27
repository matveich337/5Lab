using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab5
{
    class Program
    {
        static void Main()
        {
            List<Figure> figures = new List<Figure>();
            figures.Add(new Rectangle(5, 10, "Rectangle1"));
            figures.Add(new Rectangle(10, 50, "Rectangle2"));
            figures.Add(new Rectangle(2, 9, "Rectangle3"));
            figures.Add(new Circle(2.5, "Circle1"));
            figures.Add(new Circle(7, "Circle2"));
            figures.Add(new Circle(10, "Circle3"));
            figures.Add(new Triangle(5,8,5, "Triangle1"));
            figures.Add(new Triangle(8,4,7, "Triangle2"));
            figures.Add(new Triangle(5,4,5, "Triangle3"));

            foreach (Figure item in figures)
            {
                item.PrintInfo();
                Console.WriteLine("======================================");
            }

            using (FileStream ex = File.Create("Exercise1.txt"))
            {
                foreach (var item in figures)
                {
                    string text = $" Perimeter: {item.CalculatePerimeter()} || Square: {item.CalculateSquare()}";
                    byte[] info = new UTF8Encoding(true).GetBytes(text + '\n');
                    ex.Write(info, 0, info.Length);
                }
                ex.Close();
            }
        }
    }
}

