using Entities.Interfaces;
using System;

namespace Entities
{
    public class Student : IEntity<Student>
    {
        public int Id { get; set; }
        public int ClassroomId {  get; set; }
        public string CompleteName {  get; set; }
        public DateTime DateCreation { get; set; }
        public Classroom Classroom { get; set; }

        public Student(int id, int classroomId, string completeName, DateTime dateCreation )
        {
            Id = id;
            ClassroomId = classroomId;
            CompleteName = completeName;
            DateCreation = dateCreation;
        }
    }
}
