using System.Runtime.Serialization;

namespace CabBooking.Exceptions
{
    [Serializable]
    internal class CabAlreadyExistException : Exception
    {
        public CabAlreadyExistException()
        {
        }

        public CabAlreadyExistException(string? message) : base(message)
        {
        }

        public CabAlreadyExistException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CabAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}