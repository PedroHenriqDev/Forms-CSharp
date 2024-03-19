using Entities.Interfaces;
using System;

namespace Entities
{
    /// <summary>
    /// Represents a classroom entity.
    /// </summary>
    public class Classroom : IEntity<Classroom>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the classroom.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the classroom.
        /// </summary>
        public string ClassroomName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the associated course.
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// Gets or sets the associated course.
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Gets or sets the date of creation of the classroom.
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Classroom"/> class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier of the classroom.</param>
        /// <param name="classroomName">The name of the classroom.</param>
        /// <param name="courseId">The unique identifier of the associated course.</param>
        /// <param name="dateCreation">The date of creation of the classroom.</param>
        public Classroom(int id, string classroomName, int courseId, DateTime dateCreation)
        {
            Id = id;
            ClassroomName = classroomName;
            CourseId = courseId;
            DateCreation = dateCreation;
        }
    }
}
