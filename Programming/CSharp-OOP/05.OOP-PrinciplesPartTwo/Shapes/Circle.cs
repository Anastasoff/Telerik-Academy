// Define class Circle and suitable constructor so that at initialization height must be kept equal to width 
// and implement the CalculateSurface() method. 
namespace Shapes
{
    using System;

    public class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, radius)
        {
        }

        public double Radius
        {
            get
            {
                return this.Height;
            }

            set
            {
                this.Height = this.Width = value;
            }
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
