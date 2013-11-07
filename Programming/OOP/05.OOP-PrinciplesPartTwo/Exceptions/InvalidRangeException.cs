// Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
// It should hold error message and a range definition [start … end].

namespace Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class InvalidRangeException<T> : Exception
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        #region Constructors

        public InvalidRangeException() : base()
        {
        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {
        }

        public InvalidRangeException(string message, T start, T end, Exception inner)
            : base(message, inner)
        {
            this.Start = start;
            this.End = end;
        }

        // A constructor is needed for serialization when an 
        // exception propagates from a remote server to the client. By MSDN
        protected InvalidRangeException(SerializationInfo info, StreamingContext context)
        {
        }

        #endregion

        #region Properties

        public T Start { get; private set; }

        public T End { get; private set; }

        #endregion

        #region Methods

        public override string Message
        {
            get
            {
                return string.Format("{0} \nPermissible range: [{1} ... {2}]", base.Message, this.Start, this.End);
            }
        }

        #endregion
    }
}
