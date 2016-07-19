using System;
using System.Runtime.Serialization;

namespace Tests.Business
{
    public class CannotDeleteAnNonExistentTaskException : Exception
    {
        public CannotDeleteAnNonExistentTaskException()
        {
        }

        public CannotDeleteAnNonExistentTaskException(string message) : base(message)
        {
        }

        public CannotDeleteAnNonExistentTaskException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CannotDeleteAnNonExistentTaskException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}