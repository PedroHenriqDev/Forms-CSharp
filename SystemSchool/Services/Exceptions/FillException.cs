using System;

namespace Services.Exceptions
{
    /// <summary>
    /// Represents an exception specific to fill operations in the Services namespace.
    /// </summary>
    public class FillException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FillException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public FillException(string message) : base(message)
        {
        }
    }
}
