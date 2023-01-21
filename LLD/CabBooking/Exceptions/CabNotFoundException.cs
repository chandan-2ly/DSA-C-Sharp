using System.Runtime.Serialization;

namespace CabBooking.Exceptions
{
    [Serializable]
    internal class CabNotFoundException : Exception
    {
        public CabNotFoundException()
        {
        }

        public CabNotFoundException(string? message) : base(message)
        {
        }

        public CabNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CabNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}