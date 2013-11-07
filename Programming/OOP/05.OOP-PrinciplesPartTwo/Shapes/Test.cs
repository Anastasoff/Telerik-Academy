// 1. Write a program that tests the behavior of the CalculateSurface() method 
// for different shapes (Circle, Rectangle, Triangle) stored in an array.

namespace Shapes
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[] 
            {
                new Circle(2.5),
                new Rectangle(3, 5.5),
                new Triangle(4, 1.5)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("The surface of {0} is: {1:F2}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
