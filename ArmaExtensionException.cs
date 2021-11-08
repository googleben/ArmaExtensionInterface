using System;
using System.Runtime.Serialization;

namespace ArmaExtensionInterface
{
    [Serializable]
    public class ArmaExtensionException : Exception
    {
        public ArmaExtensionException()
        {
        }

        public ArmaExtensionException(string message) : base(message)
        {
        }

        public ArmaExtensionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArmaExtensionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
