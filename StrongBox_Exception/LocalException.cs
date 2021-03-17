using System;
using System.Runtime.Serialization;

namespace StrongBox.Exceptions {
    public class LocalException : Exception {
        public LocalException() {
        }

        public LocalException(string message) : base(message) {
        }

        public LocalException(string message, Exception innerException) : base(message, innerException) {
        }

        protected LocalException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
