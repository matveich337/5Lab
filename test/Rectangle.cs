using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Rectangle : Figure
    {
        private double x;
        private double y;
        private string name;

        public string Name
        {
            get { return name; }
        }

        public double X
        {
            get { return x; }
            set { if (value > 0) x = value; else x = 0; }
        }

        public double Y
        {
            get { return y; }
            set { if (value > 0) y = value; else y = 0; }
        }

        public Rectangle() { }

        public Rectangle(string name) { this.name = name; }

        public Rectangle(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public double CalculateSquare()
        {
            return x * y;
        }
        public double CalculatePerimeter()
        {
            return 2 * (x + y);
        }
        public void PrintInfo()
        {
            Console.WriteLine("Figure: rectangle");
            Console.WriteLine("Length = {0} | Width = {1}", x, y);
            Console.WriteLine("Square: " + this.CalculateSquare());
            Console.WriteLine("Perimeter: " + this.CalculatePerimeter());
            Console.WriteLine("Name: " + this.name);
        }
    }
}
