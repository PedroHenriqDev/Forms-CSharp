using Entities.Interfaces;
using System;

namespace Entities.TransientClasses
{
    /// <summary>
    /// Represents a query result for an entity operation.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    public class EntityQuery<T> : IEntityQuery<T> where T : class, IEntity<T>
    {
        /// <summary>
        /// Gets or sets a value indicating whether the operation was successful.
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// Gets or sets a message describing the result of the operation.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the moment when the operation occurred.
        /// </summary>
        public DateTime Moment { get; set; }

        /// <summary>
        /// Gets or sets the value associated with the operation.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQuery{T}"/> class with the specified parameters.
        /// </summary>
        /// <param name="result">A value indicating whether the operation was successful.</param>
        /// <param name="message">A message describing the result of the operation.</param>
        /// <param name="moment">The moment when the operation occurred.</param>
        /// <param name="value">The value associated with the operation.</param>
        public EntityQuery(bool result, string message, DateTime moment, T value)
        {
            Result = result;
            Message = message;
            Moment = moment;
            Value = value;
        }
    }
}
