namespace ThreeDimensionalPoint
{
    // 1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidean 3D space.
    public struct Point3D
    {
        // 2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
        public static readonly Point3D StartPoint = new Point3D(0, 0, 0);

        // 2.1 Add a static property to return the point O.
        public static Point3D GetStartPoint
        {
            get { return StartPoint; }
        }

        public int PointX { get; set; }

        public int PointY { get; set; }

        public int PointZ { get; set; }

        public Point3D(int x, int y, int z)
            : this()
        {
            this.PointX = x;
            this.PointY = y;
            this.PointZ = z;
        }        

        // 1.1 Implement the ToString() to enable printing a 3D point.
        public override string ToString()
        {
            return string.Format("Point coordinates:\nX: {0} \nY: {1} \nZ: {2}", this.PointX, this.PointY, this.PointZ);
        }
    }
}
