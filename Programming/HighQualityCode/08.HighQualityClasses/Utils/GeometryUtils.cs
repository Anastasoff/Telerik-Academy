// ********************************
// <copyright file="GeometryUtils.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Utils
{
    using System;

    /// <summary>
    /// Contains methods which are useful when working with geometric objects.
    /// </summary>
    public static class GeometryUtils
    {
        /// <summary>
        /// Returns the distance between two points in the 2D Euclidean space.
        /// </summary>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));

            return distance;
        }

        /// <summary>
        /// Returns the distance from a given point (x, y) to the origin O(0, 0).
        /// </summary>
        public static double CalcDistanceToOrigin2D(double x, double y)
        {
            double distance = CalcDistance2D(0, 0, x, y);

            return distance;
        }

        /// <summary>
        /// Returns the distance between two points in the 3D Euclidean space.
        /// </summary>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)) + ((z1 - z2) * (z1 - z2)));

            return distance;
        }

        /// <summary>
        /// Returns the distance from a given point (x, y, z) to the origin O(0, 0, 0).
        /// </summary>
        public static double CalcDistanceToOrigin3D(double x, double y, double z)
        {
            double distance = CalcDistance3D(0, 0, 0, x, y, z);

            return distance;
        }
    }
}