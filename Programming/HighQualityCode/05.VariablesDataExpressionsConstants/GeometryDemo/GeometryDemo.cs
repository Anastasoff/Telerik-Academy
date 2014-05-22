namespace GeometryDemo
{
    using System;

    using Geometry;

    internal class GeometryDemo
    {
        public static Figure GetRotatedFigure(Figure shape, double rotatingAngle)
        {
            double cosOfAngle = Math.Cos(rotatingAngle);
            double sinOfAngle = Math.Sin(rotatingAngle);

            return new Figure(
                (Math.Abs(cosOfAngle) * shape.Width) + (Math.Abs(sinOfAngle) * shape.Height),
                (Math.Abs(sinOfAngle) * shape.Width) + (Math.Abs(cosOfAngle) * shape.Height));
        }

        public static void Main()
        {
            Figure demoFigure = GetRotatedFigure(new Figure(3, 2), 45);
            Console.WriteLine(demoFigure);
        }
    }
}