// ********************************
// <copyright file="Figure.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Figures
{
    /// <summary>
    /// Represents a geometric figure.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns>The perimeter.</returns>
        public abstract double CalcPerimeter();

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>The area.</returns>
        public abstract double CalcArea();
    }
}