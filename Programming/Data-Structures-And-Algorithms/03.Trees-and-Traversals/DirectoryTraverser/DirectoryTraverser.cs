namespace DirectoryTraverser
{
    using System;
    using System.IO;

    public class DirectoryTraverser
    {
        public static void Main()
        {
            string root = @"C:\Windows";
            string mask = "*.exe";

            try
            {
                TraverseDir(root, mask);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        public static void TraverseDir(string directory, string mask)
        {
            try
            {
                string[] files = Directory.GetFiles(directory, mask);
                foreach (var file in files)
                {
                    int index = file.LastIndexOf('\\') + 1;
                    string fileName = file.Substring(index, file.Length - index);
                    Console.WriteLine(fileName);
                }

                string[] dirs = Directory.GetDirectories(directory);
                foreach (var dir in dirs)
                {
                    TraverseDir(dir, mask);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}