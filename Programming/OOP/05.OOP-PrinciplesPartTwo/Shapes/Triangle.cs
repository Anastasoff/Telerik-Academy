// Define two new classes Triangle and Rectangle that implement the virtual method
// and return the surface of the figure (height*width for rectangle and height*width/2 for triangle).
namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double side, double height)
            : base(side, height)
        {
        }

        public double Side
        {
            get
            {
                return this.Width;
            }

            set
            {
                this.Width = value;
            }
        }

        public override double CalculateSurface()
        {
            return (this.Side * this.Height) / 2;
        }
    }
}