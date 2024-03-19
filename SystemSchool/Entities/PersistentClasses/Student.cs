using Entities.Interfaces;
using System;

namespace Entities
{
    /// <summary>
    /// Represents a student entity.
    /// </summary>
    public class Student : IEntity<Student>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the student.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the classroom the student belongs to.
        /// </summary>
        public int ClassroomId { get; set; }

        /// <summary>
        /// Gets or sets the complete name of the student.
        /// </summary>
        public string CompleteName { get; set; }

        /// <summary>
        /// Gets or sets the date of creation of the student.
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Gets or sets the classroom associated with the student.
        /// </summary>
        public Classroom Classroom { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier of the student.</param>
        /// <param name="classroomId">The identifier of the classroom the student belongs to.</param>
        /// <param name="completeName">The complete name of the student.</param>
        /// <param name="dateCreation">The date of creation of the student.</param>
        public Student(int id, int classroomId, string completeName, DateTime dateCreation)
        {
            Id = id;
            ClassroomId = classroomId;
            CompleteName = completeName;
            DateCreation = dateCreation;
        }
    }
}
