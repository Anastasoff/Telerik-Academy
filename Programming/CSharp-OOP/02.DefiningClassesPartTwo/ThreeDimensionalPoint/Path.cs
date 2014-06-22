namespace ThreeDimensionalPoint
{
    using System.Collections.Generic;

    // 4. Create a class Path to hold a sequence of points in the 3D space. 
    public class Path
    {
        public readonly List<Point3D> Points = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            this.Points.Add(point);
        }
    }
}
