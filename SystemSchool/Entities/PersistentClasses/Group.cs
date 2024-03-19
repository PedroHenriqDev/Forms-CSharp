using Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Represents a group entity.
    /// </summary>
    public class Group : IEntity<Group>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the group.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the access level of the group.
        /// </summary>
        public int AccessLevel { get; set; }

        /// <summary>
        /// Gets or sets the name of the group.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the date of creation of the group.
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Gets or sets the list of users associated with the group.
        /// </summary>
        public List<User> Users { get; set; }
    }
}
