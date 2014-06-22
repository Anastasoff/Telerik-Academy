namespace ThreeDimensionalPoint
{
    using System.IO;
    using System.Text;

    // 4.1 Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../Save.txt"))
            {
                foreach (var point in path.Points)
                {
                    writer.WriteLine("X: {0}, Y: {1}, Z: {2}", point.PointX, point.PointY, point.PointZ);
                }
            }
        }

        public static string LoadPath()
        {
            StringBuilder result = new StringBuilder();
            using (StreamReader reader = new StreamReader(@"../../Load.txt"))
            {
                result.Append(reader.ReadToEnd());
            }

            return result.ToString();
        }
    }
}
