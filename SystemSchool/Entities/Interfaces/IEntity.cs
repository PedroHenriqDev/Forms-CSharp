using System;

namespace Entities.Interfaces
{
    /// <summary>
    /// Interface representing an entity with a generic type T.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    public interface IEntity<T>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the entity.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the entity.
        /// </summary>
        DateTime DateCreation { get; set; }
    }
}
