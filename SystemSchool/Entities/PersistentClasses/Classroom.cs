using Entities.Interfaces;
using System;

namespace Entities
{
    public class Classroom : IEntity<Classroom>
    {
        public int Id { get; set; }
        public string ClassroomName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime DateCreation { get; set; }

        public Classroom(int id, string classroomName, int courseId, DateTime dateCreation)
        {
            Id = id;
            ClassroomName = classroomName;
            CourseId = courseId;
            DateCreation = dateCreation;
        }
    }
}
