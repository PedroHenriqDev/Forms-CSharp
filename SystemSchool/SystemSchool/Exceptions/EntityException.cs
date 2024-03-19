using System;

namespace SystemSchool.Expections
{
    /// <summary>
    /// Represents an exception specific to entities in the SystemSchool namespace.
    /// </summary>
    public class EntityException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public EntityException(string message) : base(message)
        {
        }
    }
}
