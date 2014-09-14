namespace Frames
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        private static SortedSet<string> result;

        public static void Main()
        {
            result = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());
            var frames = new Frame[n];
            for (int i = 0; i < n; i++)
            {
                string[] currentFrame = Console.ReadLine().Split(' ');
                frames[i] = new Frame(int.Parse(currentFrame[0]), int.Parse(currentFrame[1]));
            }

            Perm(frames, 0);

            StringBuilder sb = new StringBuilder();

            foreach (var item in result)
            {
                sb.AppendLine(item);
            }

            Console.WriteLine(result.Count);
            Console.WriteLine(sb.ToString().Trim());
        }

        private static void Perm(Frame[] arr, int k)
        {
            if (k >= arr.Length)
            {
                result.Add(string.Join(" | ", arr));
            }
            else
            {
                Perm(arr, k + 1);
                SwapSizes(ref arr[k]);

                Perm(arr, k + 1);
                SwapSizes(ref arr[k]);

                for (int i = k + 1; i < arr.Length; i++)
                {
                    SwapFrame(ref arr[k], ref arr[i]);

                    Perm(arr, k + 1);
                    SwapSizes(ref arr[k]);
                    Perm(arr, k + 1);
                    SwapSizes(ref arr[k]);

                    SwapFrame(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void SwapFrame(ref Frame first, ref Frame second)
        {
            Frame swap = first;
            first = second;
            second = swap;
        }

        private static void SwapSizes(ref Frame frame)
        {
            int swap = frame.Width;
            frame.Width = frame.Height;
            frame.Height = swap;
        }
    }

    public struct Frame
    {
        public Frame(int width, int height)
            : this()
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public override string ToString()
        {
            return string.Format("({0}, {1})", this.Width, this.Height);
        }
    }
}