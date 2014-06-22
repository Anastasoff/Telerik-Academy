namespace FiguresDemo
{
    using System;

    using Figures;

    public class FiguresDemo
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("Circle:\n - perimeter = {0:f2} \n - area = {1:f2}", circle.CalcPerimeter(), circle.CalcArea());

            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine("Rectangle:\n - perimeter = {0:f2} \n - surface = {1:f2}", rectangle.CalcPerimeter(), rectangle.CalcArea());
        }
    }
}