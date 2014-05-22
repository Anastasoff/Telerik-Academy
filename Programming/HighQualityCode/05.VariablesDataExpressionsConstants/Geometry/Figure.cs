// ********************************
//
// <copyright file="Figure.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Geometry
{
    using System;

    /// <summary>
    /// Represents a 2D figure with width and height.
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// The width of the figure.
        /// </summary>
        private double width;

        /// <summary>
        /// The height of the figure.
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry.Figure"/> class.
        /// </summary>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the width of this <see cref="Geometry.Figure"/>.
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
                    throw new ArgumentException("Width must be positive number.");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of this <see cref="Geometry.Figure"/>.
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
                    throw new ArgumentException("Height must be positive number.");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Returns the string representation of this <see cref="Geometry.Figure"/>
        /// </summary>
        /// <returns>A string containing the width and height of the figure.</returns>
        public override string ToString()
        {
            return string.Format("Rectangle(width: {0:N4}, height: {1:N4})", this.width, this.height);
        }
    }
}