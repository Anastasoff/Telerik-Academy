// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.CheckInput(value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.CheckInput(value);
                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        private void CheckInput(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The value should be positive number!");
            }
        }
    }
}