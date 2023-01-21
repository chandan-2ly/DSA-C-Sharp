using System.Runtime.Serialization;

namespace CabBooking.Exceptions
{
    [Serializable]
    internal class TripNotFoundException : Exception
    {
        public TripNotFoundException()
        {
        }

        public TripNotFoundException(string? message) : base(message)
        {
        }

        public TripNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TripNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}