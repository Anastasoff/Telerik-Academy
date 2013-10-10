namespace ThreeDimensionalPoint
{
    using System;

    // 3. Write a static class with a static method to calculate the distance between two points in the 3D space.
    public static class Distance
    {
        public static double CalcDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0.0;
            double deltaX = secondPoint.PointX - firstPoint.PointX;
            double deltaY = secondPoint.PointY - firstPoint.PointY;
            double deltaZ = secondPoint.PointZ - firstPoint.PointZ;
            distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));
            return distance;
        }
    }
}
