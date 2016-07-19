using System;
using System.Runtime.Serialization;

namespace DaKingToDo.Business
{
    [Serializable]
    public class CannotCreateAnEmptyTaskException : Exception
    {
        public CannotCreateAnEmptyTaskException()
        {
        }

        public CannotCreateAnEmptyTaskException(string message) : base(message)
        {
        }

        public CannotCreateAnEmptyTaskException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CannotCreateAnEmptyTaskException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}