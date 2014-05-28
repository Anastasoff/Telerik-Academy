// ********************************
// <copyright file="Circle.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Figures
{
    using System;

    /// <summary>
    /// Represents a circle.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Circle's radius.
        /// </summary>
        private double radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="System.ArgumentException">Thrown when <paramref name="radius"/> is negative.</exception>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets the radius of circle.
        /// </summary>
        /// <value>Gets or sets the value of the radius field.</value>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius cannot be less than zero.");
                }

                this.radius = value;
            }
        }

        /// <summary>
        /// Calculates the perimeter of the circle.
        /// </summary>
        /// <returns>The perimeter.</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area.</returns>
        public override double CalcArea()
        {
            double area = Math.PI * this.Radius * this.Radius;

            return area;
        }
    }
}