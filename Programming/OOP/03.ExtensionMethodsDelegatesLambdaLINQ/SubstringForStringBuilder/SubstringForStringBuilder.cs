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
            StringBuilder sb = new StringBuilder();
            sb.Append("0123456789");
            Console.WriteLine("Substring(Int32): " + sb.Substring(2));
            Console.WriteLine("Substring(Int32, Int32): " + sb.Substring(2, 6));            
        }
    }
}
