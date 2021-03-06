﻿// Define two new classes Triangle and Rectangle that implement the virtual method
// and return the surface of the figure (height*width for rectangle and height*width/2 for triangle).
namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}