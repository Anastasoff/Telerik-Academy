namespace Version
{
    using System;

    // 11. Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor
    [AttributeUsage(AttributeTargets.Class | 
        AttributeTargets.Enum | 
        AttributeTargets.Method | 
        AttributeTargets.Interface | 
        AttributeTargets.Struct)]

    public class VersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public int Major
        {
            get
            {
                return this.major;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
        }
    }
}
