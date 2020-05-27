using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Triangle : Figure
    {
        private double x;
        private double y;
        private double z;
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
        public double Z
        {
            get { return z; }
            set { if (value > 0) z = value; else z = 0; }
        }

        public Triangle() { }

        public Triangle(string name) { this.name = name; }

        public Triangle(double x, double y, double z, string name)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.name = name;
        }
        public double CalculateSquare()
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
        public double CalculatePerimeter()
        {
            return x + y + z;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Figure: triangle");
            Console.WriteLine("1 side = {0} | 2 side = {1} | 3 side = {2}", x, y, z);
            Console.WriteLine("Square: " + this.CalculateSquare());
            Console.WriteLine("Perimeter: " + this.CalculatePerimeter());
            Console.WriteLine("Name: " + this.name);
        }
    }
}
