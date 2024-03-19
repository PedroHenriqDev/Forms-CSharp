using Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Represents a course entity.
    /// </summary>
    public class Course : IEntity<Course>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the course.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// Gets or sets the date of creation of the course.
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Gets or sets the list of classrooms associated with the course.
        /// </summary>
        public List<Classroom> Classrooms { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier of the course.</param>
        /// <param name="courseName">The name of the course.</param>
        /// <param name="dateCreation">The date of creation of the course.</param>
        public Course(int id, string courseName, DateTime dateCreation)
        {
            Id = id;
            CourseName = courseName;
            DateCreation = dateCreation;
        }
    }
}
