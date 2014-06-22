namespace UtilsDemo
{
    using System;

    public class RectangularCuboid
    {
        private double width;
        private double height;
        private double depth;

        public RectangularCuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("RectangularCuboid's width cannot be less or equal to zero.");
                }

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
                if (value <= 0)
                {
                    throw new ArgumentException("RectangularCuboid's height cannot be less or equal to zero.");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("RectangularCuboid's depth cannot be less or equal to zero.");
                }

                this.depth = value;
            }
        }
    }
}