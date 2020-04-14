using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Geometry
    {
        public abstract double Area { get; set; }
        public abstract double Perimeter { get; set; }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }

    public class Circle : Geometry
    {

        public Circle (double radius)
        {
            this.Radius = radius;
        }

        private double Radius { get; set; }

        public override double Area { get; set; }
        public override double Perimeter { get; set; }


        public override void CalculateArea()
        {
            this.Area = Radius * Radius * Math.PI;
            
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * Radius * Math.PI;
        }
    }


    public class Rectangle : Geometry
    {
        public Rectangle (double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public Rectangle (double side)
        {
            this.Length = side;
            this.Width = side;
        }

        private double Length { get; set; }
        private double Width { get; set; }

        public override double Area { get; set; }
        public override double Perimeter { get; set; }

        
        public override void CalculateArea()
        {
            this.Area = Length * Width;
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = (2 * Length) + (2 * Width);
        }
    }

}
