using System.Runtime.Serialization;

namespace CabBooking.Exceptions
{
    [Serializable]
    internal class RiderAlreadyExistException : Exception
    {
        public RiderAlreadyExistException()
        {
        }

        public RiderAlreadyExistException(string? message) : base(message)
        {
        }

        public RiderAlreadyExistException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RiderAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}