namespace SubstringFinder.Services
{
    using System;
    using System.Text.RegularExpressions;

    public class SubstringFinder : ISubstringFinder
    {
        public int GetSubstringCount(string text, string substr)
        {
            if (text == null)
            {
                throw new NullReferenceException("Parameter 'text' cannot be null.");
            }

            if (substr == null)
            {
                throw new NullReferenceException("Parameter 'substr' cannot be null");
            }

            int count = Regex.Matches(text, substr).Count;

            return count;
        }
    }
}