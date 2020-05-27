using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Circle : Figure
    {
        private double r;

        private string name;

        public Circle() { }

        public Circle(string name) { this.name = name; }

        public Circle(double r, string name)
        {
            this.r = r;
            this.name = name;
        }

        public double R
        {
            get { return r; }
            set { if (value > 0) r = value; else r = 0; }
        }

        public string Name
        {
            get { return name; }
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * r;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Figure: circle");
            Console.WriteLine("Radius = {0}", r);
            Console.WriteLine("Square: " + this.CalculateSquare());
            Console.WriteLine("Perimeter: " + this.CalculatePerimeter());
            Console.WriteLine("Name: " + this.name);
        }
    }
}
