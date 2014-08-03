namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class1 : IComparable<Class1>
    {
        private string name;
        private SortedSet<string> strings;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value.ToLowerInvariant();
            }
        }

        public SortedSet<string> Strings
        {
            get
            {
                return this.strings;
            }

            set
            {
                this.strings = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append('[');
            sb.Append(this.Name);
            bool flag = true;
            foreach (var phone in this.Strings)
            {
                if (flag)
                {
                    sb.Append(": ");
                    flag = false;
                }
                else
                {
                    sb.Append(", ");
                }

                sb.Append(phone);
            }

            sb.Append(']');
            return sb.ToString();
        }

        public int CompareTo(Class1 other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}