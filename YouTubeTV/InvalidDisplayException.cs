using System;
using System.Runtime.Serialization;

namespace YouTubeTV
{
    [Serializable]
    internal class InvalidDisplayException : Exception
    {
        public InvalidDisplayException()
        {
        }

        public InvalidDisplayException(string message) : base(message)
        {
        }

        public InvalidDisplayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidDisplayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}