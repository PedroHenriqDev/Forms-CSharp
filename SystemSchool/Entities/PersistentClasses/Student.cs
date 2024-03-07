using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public int ClassroomId {  get; set; }
        public Classroom Classroom { get; set; }
        public string CompleteName {  get; set; }

        public Student(int id, int classroomId, string completeName )
        {
            Id = Id;
            ClassroomId = classroomId;
            CompleteName = completeName;
        }
    }
}
