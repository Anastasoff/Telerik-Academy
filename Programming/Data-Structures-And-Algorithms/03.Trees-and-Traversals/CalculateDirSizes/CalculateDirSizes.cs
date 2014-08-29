namespace CalculateDirSizes
{
    using System;
    using System.IO;

    internal class CalculateDirSizes
    {
        public static void Main()
        {
            string root = @"C:\Windows";
            long totalSize = TraverseDir(root);

            Console.WriteLine(Environment.NewLine + "Total size: {0:N} MB", totalSize / 1024000.0);
        }

        public static long TraverseDir(string directory)
        {
            long totalSize = 0L;
            try
            {
                long currentDirSize = 0L;
                DirectoryInfo currentDir = new DirectoryInfo(directory);
                FileInfo[] files = currentDir.GetFiles();
                foreach (FileInfo file in files)
                {
                    currentDirSize += file.Length;
                }

                totalSize += currentDirSize;

                string[] dirs = Directory.GetDirectories(directory);
                foreach (var dir in dirs)
                {
                    totalSize += TraverseDir(dir);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return totalSize;
        }
    }
}