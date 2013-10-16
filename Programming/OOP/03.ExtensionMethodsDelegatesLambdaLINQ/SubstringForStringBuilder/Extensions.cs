namespace SubstringForStringBuilder
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex)
        {
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("StartIndex cannot be less than zero.");
            }

            if (startIndex > input.Length)
            {
                throw new ArgumentOutOfRangeException("StartIndex cannot be larger than length of StringBuilder.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = startIndex; i < input.Length; i++)
            {
                result.Append(input[i]);
            }

            return result;
        }

        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("StartIndex cannot be less than zero.");
            }

            if (startIndex > input.Length)
            {
                throw new ArgumentOutOfRangeException("StartIndex cannot be larger than length of StringBuilder.");
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("Length cannot be less than zero.");
            }

            if (startIndex > input.Length - length)
            {
                throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
            }

            if (length > input.Length)
            {
                throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = startIndex; i < startIndex + length; i++)
            {
                result.Append(input[i]);
            }

            return result;
        }
    }
}
