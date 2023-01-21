using System.Runtime.Serialization;

namespace CabBooking.Exceptions
{
    [Serializable]
    internal class RiderNotFoundException : Exception
    {
        public RiderNotFoundException()
        {
        }

        public RiderNotFoundException(string? message) : base(message)
        {
        }

        public RiderNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RiderNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}