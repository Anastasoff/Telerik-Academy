// ********************************
// <copyright file="FileUtils.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Utils
{
    using System;

    /// <summary>
    /// Performs operations on <see cref="System.String"/> instances
    /// that contain file or directory path information.
    /// </summary>
    public static class FileUtils
    {
        /// <summary>
        /// Returns the extension of the specified path string.
        /// </summary>
        public static string GetFileExtension(string path)
        {
            CheckInputPath(path);

            int lastDotIndex = path.LastIndexOf(".");
            if (lastDotIndex == -1)
            {
                return string.Empty;
            }

            string extension = path.Substring(lastDotIndex + 1);

            return extension;
        }

        /// <summary>
        /// Returns the file name of the specified path string without the extension.
        /// </summary>
        public static string GetFileNameWithoutExtension(string path)
        {
            CheckInputPath(path);

            int lastDotIndex = path.LastIndexOf(".");
            if (lastDotIndex == -1)
            {
                return path;
            }

            string fileNameWithoutExtension = path.Substring(0, lastDotIndex);

            return fileNameWithoutExtension;
        }


        private static void CheckInputPath(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("Path is null.");
            }

            if (path.Length == 0)
            {
                throw new ArgumentException("Path is empty.");
            }
        }
    }
}