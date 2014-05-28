// ********************************
// <copyright file="Rectangle.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Figures
{
    using System;

    /// <summary>
    /// Represents a rectangle.
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// Rectangle's width.
        /// </summary>
        private double width;

        /// <summary>
        /// Rectangle's height.
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <exception cref="System.ArgumentException">Thrown when <paramref name="width"/>
        /// or <paramref name="height"/> is negative.</exception>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the width of rectangle.
        /// </summary>
        /// <value>Gets or sets the value of the width field.</value>
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
                    throw new ArgumentException("Width cannot be less than zero.");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of rectangle.
        /// </summary>
        /// <value>Gets or sets the value of the height field.</value>
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
                    throw new ArgumentException("Height cannot be less than zero.");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle.
        /// </summary>
        /// <returns>The perimeter.</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        /// <returns>The area.</returns>
        public override double CalcArea()
        {
            double area = this.Width * this.Height;

            return area;
        }
    }
}