namespace Version
{
    using System;

    [Version(2, 11)]
    public class VersionTest
    {
        // 11.1 Apply the version attribute to a sample class and display its version at runtime.
        public static void Main()
        {
            Type attributeType = typeof(VersionTest);
            var allAttributes = attributeType.GetCustomAttributes(false);
            foreach (VersionAttribute attributes in allAttributes)
            {
                Console.WriteLine("Version: {0}.{1}", attributes.Major, attributes.Minor);
            }
        }
    }
}
