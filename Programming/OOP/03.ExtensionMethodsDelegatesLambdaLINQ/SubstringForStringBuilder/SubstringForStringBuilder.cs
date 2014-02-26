// 1. Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
//      and has the same functionality as Substring in the class String.

namespace SubstringForStringBuilder
{
    using System;
    using System.Text;

    public class SubstringForStringBuilder
    {
        public static void Main()
        {
            string str = "0123456789";
            Console.WriteLine("str.Substring(Int32) = " + str.Substring(2));
            Console.WriteLine("str.Substring(Int32, Int32) = " + str.Substring(2, 6));

            Console.WriteLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("0123456789");
            Console.WriteLine("sb.Substring(Int32) = " + sb.Substring(2));
            Console.WriteLine("sb.Substring(Int32, Int32) = " + sb.Substring(2, 6));
        }
    }
}