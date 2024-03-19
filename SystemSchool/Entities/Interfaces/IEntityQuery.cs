using System;

namespace Entities.Interfaces
{
    /// <summary>
    /// Interface defining a generic query object for entities.
    /// </summary>
    /// <typeparam name="T">The type of entity associated with the query.</typeparam>
    public interface IEntityQuery<T> where T : class
    {
        /// <summary>
        /// Gets or sets a value indicating whether the query was successful.
        /// </summary>
        bool Result { get; set; }

        /// <summary>
        /// Gets or sets a message related to the query.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Gets or sets the moment when the query was executed.
        /// </summary>
        DateTime Moment { get; set; }

        /// <summary>
        /// Gets or sets the value associated with the query, which is an instance of the generic entity T.
        /// </summary>
        T Value { get; set; }
    }
}
