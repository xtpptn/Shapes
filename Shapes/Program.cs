using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Rectangle square = new Rectangle(5);

            circle.CalculateArea();
            circle.CalculatePerimeter();
            Console.WriteLine(circle.Area);
            Console.WriteLine(circle.Perimeter);

            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();
            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Perimeter);

            square.CalculateArea();
            square.CalculatePerimeter();
            Console.WriteLine(square.Area);
            Console.WriteLine(square.Perimeter);

        }
    }
}
