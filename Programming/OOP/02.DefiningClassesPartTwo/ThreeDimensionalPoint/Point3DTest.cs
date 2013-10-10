namespace ThreeDimensionalPoint
{
    using System;
    using System.Collections.Generic;

    public class Point3DTest
    {
        public static void Main()
        {
            Point3D firstPoint = new Point3D(-5, 2, 10);
            Point3D secondPoint = new Point3D(4, 0, -6);
            Console.WriteLine(Distance.CalcDistance(firstPoint, secondPoint));

            Path savedPath = new Path();
            savedPath.AddPoint(firstPoint);
            savedPath.AddPoint(secondPoint);
            PathStorage.SavePath(savedPath);

            Console.WriteLine(PathStorage.LoadPath());
        }
    }
}
