using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesNew
{
    public class Geometry
    {
        public double Area { get; protected set; }
        public double Perimeter { get; protected set; }

        public void CalculateArea()
        {
            Console.WriteLine("You will need to Override the base method");
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine("You will need to Override the base method");
        }
    }

    public class Circle : Geometry
    {

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        private double Radius { get; set; }


        public new void CalculateArea()
        {
            this.Area = Radius * Radius * Math.PI;

        }

        public new void CalculatePerimeter()
        {
            this.Perimeter = 2 * Radius * Math.PI;
        }
    }


    public class Rectangle : Geometry
    {
        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public Rectangle(double side)
        {
            this.Length = side;
            this.Width = side;
        }

        private double Length { get; set; }
        private double Width { get; set; }


        public new void CalculateArea()
        {
            this.Area = Length * Width;
        }

        public new void CalculatePerimeter()
        {
            this.Perimeter = (2 * Length) + (2 * Width);
        }
    }
}
